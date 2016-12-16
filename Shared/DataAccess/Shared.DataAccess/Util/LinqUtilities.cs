using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Mvc6Recipes.Shared.DataAccess.Util
{
    public static class LinqUtilities
    {
        public static Expression<Func<TElement, bool>> BuildOrExpression<TElement, TValue>(
        Expression<Func<TElement, TValue>> valueSelector,
        IEnumerable<TValue> values
    )
        {
            if (null == valueSelector)
                throw new ArgumentNullException("valueSelector");
            if (null == values)
                throw new ArgumentNullException("values");
            ParameterExpression p = valueSelector.Parameters.Single();

            if (!values.Any())
                return e => false;

            var equals = values.Select(value =>
                (Expression)Expression.Equal(
                     valueSelector.Body,
                     Expression.Constant(
                         value,
                         typeof(TValue)
                     )
                )
            );
            var body = equals.Aggregate<Expression>(
                     (accumulate, equal) => Expression.Or(accumulate, equal)
             );

            return Expression.Lambda<Func<TElement, bool>>(body, p);
        }

        public static IOrderedQueryable<T> OrderByText<T>(
            this IQueryable<T> source,
            string property)
        {
            if (string.IsNullOrEmpty(property))
                throw new ArgumentNullException("property");

            return ApplyOrder<T>(source, property, "OrderBy");
        }



        //this method creates the expression and the uses 
        // reflection to construct a method call
        // breaking out into an second method allows us to create variations
        // that can use other methods such as OrderByDescending
        public static IOrderedQueryable<T> ApplyOrder<T>(
                                IQueryable<T> source,
                                 string property,
                                 string methodName)
        {
            string[] props = property.Split('.');
            Type type = typeof(T);
            ParameterExpression arg = Expression.Parameter(type, "x");
            Expression expr = arg;
            foreach (string prop in props)
            {
                // use reflection to get meta data for
                // the object we wish to sort by
                PropertyInfo pi = type.GetRuntimeProperty(prop);
                expr = Expression.Property(expr, pi);
                type = pi.PropertyType;
            }
            //Create the Lambda expression
            Type delegateType =
              typeof(Func<,>).MakeGenericType(typeof(T), type);
            LambdaExpression lambda =
              Expression.Lambda(delegateType, expr, arg);

            // use reflection to call the sort method using the 
            // Lambda expression
            object result = typeof(Queryable).GetRuntimeMethods().Single(
                    method => method.Name == methodName
                            && method.IsGenericMethodDefinition
                            && method.GetGenericArguments().Length == 2
                            && method.GetParameters().Length == 2)
                    .MakeGenericMethod(typeof(T), type)
                    .Invoke(null, new object[] { source, lambda });
            return (IOrderedQueryable<T>)result;
        }

    }


}

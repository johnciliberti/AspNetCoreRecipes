// created named export for authorFirstName
// using new ES6 short hand equivalent to { authorFirstName : authorFirstName  }
const authorFirstName = 'John';
export { authorFirstName };

// declare and export variable name on one line
export const authorLastName = 'Ciliberti';

// export multiple objects
const arrayOfNumbers = [1, 2, 3, 4];
const someObject = {
  prop1: 'value 1',
  prop2: 'value 2'
};
export {
  arrayOfNumbers,
  someObject
};

// named export for a function
export function printWarning(message) {
  console.warn(message);
}

// default export function that returns string 'Test'
export default ('New ES6 return statement shorthand');

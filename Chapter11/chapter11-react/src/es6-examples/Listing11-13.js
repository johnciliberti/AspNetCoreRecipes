// example 1
const noCurlyBracesRequired = () => console.log('This is an arrow function with no arguments');
noCurlyBracesRequired();
// This is an arrow function with no arguments

const noParenthesisRequired = a => console.log(`The value of the a argument is ${a}`);
noParenthesisRequired('foo');
// The value of the a argument is foo

const requiresParenthesisAndCurlyBraces = (a, b, c) => {
  console.log(`The value of the a argument is ${a}`);
  console.log(`The value of the b argument is ${b}`);
  c();
};

requiresParenthesisAndCurlyBraces('foo', 'bar', () => console.log('bat'));
// The value of the a argument is foo
// The value of the b argument is bar
// bat


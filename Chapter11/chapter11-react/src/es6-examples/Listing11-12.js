// following line of code will cause build to fail
global1 = 'this is a global variable';

let global2 = 'this is also a global variable';

function vars() {
    // this line will also cause a build error
  global3 = 'this is also a global variable';

  let varsScope1 = 'scoped at vars';
  if (1 === 1) {
      let varsScope2 = 'Scoped in vars function (not the if block)';
      let scopedInIfBlock = 'This is scoped in the if block.';
      const constInIfBlock = 'I am scoped to if block and can not change';
      scopedInIfBlock = 'my value can change';
    }
}

// JS Hoisting

//function scope

var x = function() {
  var y = 1; // y has function scope only
};

//block scope
var x2 = function() {
  if (true) {
    var y2 = 1; // y2 has block scope, but var also ignores block boundaries
  }
};

x();

// Hoisting
//

var x3 = function() {
  var y3 = 1;
};
//hoisted expanded..
var x4 = function() {
  var y4; // so hoist it yourself so that you know what is happening
  y4 = 1;
};

// tricky question...
var y5 = 2;
var x5 = function() {
  console.log(y5); // "var y5;" below is hoisted by JS to top of function above console.log, so console would read as 'undefined'.
  var y5 = 1;
};
x5();

// Constant keyword

const PI = 3.14;
//PI = 2; // creates error
console.log(PI);

// Let keyword
// block scope and no hoisting

let d = function() {
  if (true) {
    let e = 1;
  }
};
console.log(e); // error, "e" only available in 'if' block scope

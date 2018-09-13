//copy an array
let a = [1, 2, 3, 4];

// let b = a; //not a copy, b is a reference to a

//ES5
// so use for, push
let b = [];
for (let i = 0; i < a.length; i++) {
  b.push(a[i]);
}
//console.log(b);

//also
b = [].concat(a);
//console.log(b);

//ES6 syntax
let c = [1, 2, 3, 4, 5];

// object assign
let d = Object.assign([], c);

//console.log(d);

//ES6 spread operator
let e = [...c];
//console.log(e);

//-----------------------------------------
// ES6 fat arrow

//old way
// var getA = function (a){
//   return a;
// }

// fat arrow version
let getA = a => a;
console.log(getA(1));

let square = a => a * a;
console.log(square(4));

//also written as...
let square1 = a => {
  return a * a;
};
console.log(square1(3));

// also without argument
var f = 5;
let square2 = () => {
  return f * f;
};
console.log(square2());

// with multiple arguments
let mult = (g, h) => {
  return g * h;
};
console.log(mult(4, 5));
//-------------------------------------
//without fat arrow
var x = function() {
  var that = this;
  this.val = 1;
  setTimeout(function() {
    that.val++;
    //console.log(that.val);
  }, 1);
};
var xx = new x();

//with fat arrow
var x = function() {
  this.val = 1;
  setTimeout(() => {
    // fat arrow uses parent for 'this'
    this.val++;
    //console.log(this.val);
  }, 1);
};
var xx = new x();

//arguments fine for function call, but no arguments for fat arrow
// var x = function() {
//   console.log(arguments[0]);
// };
// x(1, 2, 3);

//but no arguments for fat arrow
var x = () => {
  //console.log(arguments[0]);
};
x(1, 2, 3);

// fix is to use ... spread operator
var y = (...yy) => {
  console.log('test ' + yy[1]);
};
y(14, 15, 16);

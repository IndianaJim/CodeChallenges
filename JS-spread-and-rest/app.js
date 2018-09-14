// spread and rest operators in Javascript

var x = function(...n) {
  //unknown # of argumentss
  console.log(n); // n becomes array with all the arguments
};

x(1, 2, 3, 4);

var y = function(a, b, c, ...n) {
  console.log(n); // n becomes array with all the rest of the arguments
};

x(1, 2, 3, 4, 5, 6, 7, 8);

var dowhatever = ['fun', 'more fun', 'live'];
// unknown middle arguments
var life = ['born', 'walk', 'learn', ...dowhatever, 'heaven'];
console.log(life);

var a = [1, 2, 3];
var b = [4, 5, 6];
a.push(...b);
console.log(a);

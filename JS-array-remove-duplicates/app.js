// remove duplicate values from array

let a = [1, 2, 5, 2, 1, 8];

//brute force
// let b = [];
// let len = a.length; //speeds up for loop
// for (let i = 0; i < len; i++) {
//   if (b.indexOf(a[i]) === -1) {
//     b.push(a[i]);
//   }
// }

//sorted
// a.sort(); //[1,1,2,2,5,8]
// let _temp;
// for (let i = 0; i < len; i++) {
//   if (a[i] !== _temp) {
//     b.push(a[i]);
//     _temp = a[i];
//   }
// }

//object method
// obj = {};
// for (let i of a) {
//   obj[i] = true;
// }
// let b = Object.keys(obj);
// console.log(b);

//one line
console.log([...new Set(a)]); //Set only stores unique values

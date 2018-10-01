// JS async await practice

// without async/await first...

// console.log('person1 shows ticket');
// console.log('person2 shows ticket');

// const promiseWifeBringingTickets = new Promise((resolve, reject) => {
//   setTimeout(() => {
//     resolve('ticket');
//   }, 3000);
// });

// // promiseWifeBringingTickets.then(t => {
// //   console.log(`person3: shows ${t}`);
// // });

// // console.log('person4 shows ticket');
// // console.log('person5 shows ticket');

// const getPopcorn = promiseWifeBringingTickets.then(t => {
//   console.log('wife: i have tickets');
//   console.log('husband: we should go in');
//   console.log('wife: no i am hungry');
//   return new Promise((resolve, reject) => resolve(`${t} popcorn`));
// });

// const getButter = getPopcorn.then(t => {
//   console.log('husband: I got some popcorn');
//   console.log('husband: we should go in');
//   console.log('wife: no i need butter on my popcorn');
//   return new Promise((resolve, reject) => resolve(`${t} butter`));
// });

// getButter.then(t => console.log(t));

// console.log('person4 shows ticket');
// console.log('person5 shows ticket');

//now with async/await...

console.log('person1 shows ticket');
console.log('person2 shows ticket');

const preMovie = async () => {
  const promiseWifeBringingTickets = new Promise((resolve, reject) => {
    setTimeout(() => resolve('ticket'), 3000);
  });

  const getPopcorn = new Promise((resolve, reject) => resolve(`popcorn`));

  const getButter = new Promise((resolve, reject) => resolve(`butter`));

  let ticket = await promiseWifeBringingTickets;

  console.log('wife: i have tickets');
  console.log('husband: we should go in');
  console.log('wife: no i am hungry');

  let popcorn = await getPopcorn;
  console.log('husband: I got some popcorn');
  console.log('husband: we should go in');
  console.log('wife: no i need butter on my popcorn');

  let butter = await getButter;

  console.log('husband: i got the butter');
  console.log('husband: anything else');
  console.log('wife: no, we are late');

  return ticket;
};

preMovie().then(m => console.log(`person 3: shows ${m}`));

console.log('person4 shows ticket');
console.log('person5 shows ticket');

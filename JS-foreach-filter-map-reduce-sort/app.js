// JS higher order functions and arrays

const companies = [
  { name: 'Company One', category: 'Finance', start: 1981, end: 2003 },
  { name: 'Company Two', category: 'Retail', start: 1992, end: 2008 },
  { name: 'Company Three', category: 'Auto', start: 1999, end: 2007 },
  { name: 'Company Four', category: 'Retail', start: 1989, end: 2010 },
  { name: 'Company Five', category: 'Technology', start: 2009, end: 2014 },
  { name: 'Company Six', category: 'Finance', start: 1987, end: 2010 },
  { name: 'Company Seven', category: 'Auto', start: 1986, end: 1996 },
  { name: 'Company Eight', category: 'Technology', start: 2011, end: 2016 },
  { name: 'Company Nine', category: 'Retail', start: 1981, end: 1989 }
];

const ages = [33, 12, 20, 16, 5, 54, 21, 44, 61, 13, 15, 45, 25, 64, 32];

// old for loop method
for (let i = 0; i < companies.length; i++) {
  //console.log(companies[i]);
}

// forEach

companies.forEach(function(company) {
  //console.log(company.name);
});

// filter

// old way for loop
// let canDrink = [];
// for (let i = 0; i < ages.length; i++) {
//   if (ages[i] >= 21) {
//     canDrink.push(ages[i]);
//   }
// }
// console.log(canDrink);

// filter way - get 21 and older

// const canDrink = ages.filter(function(age) {
//   if (age >= 21) {
//     return true;
//   }
// });

// or filter with fat arrow
// const canDrink = ages.filter(age => age >= 21);
// console.log(canDrink);

// filter retail companies
// const retailCompanies = companies.filter(function(company) {
//   if (company.category === 'Retail') {
//     return true;
//   }
// });
// console.log(retailCompanies);

// const retailCompanies = companies.filter(
//   company => company.category === 'Retail'
// );
// console.log(retailCompanies);

//get 80's companies
// const eightiesCompanies = companies.filter(company => (company.start > 1979 && company.start < 1990));
// console.log(eightiesCompanies);

//get companies that lasted longer than 10 yrs
// const oldCompanies = companies.filter(
//   company => company.end - company.start > 10
// );
//console.log(oldCompanies);

// map
//create array of company names
// const companyNames = companies.map(function(company) {
//   return company.name;
// });

// Map using fat arrow
//const companyNames = companies.map(company => company.name);

// Map using more fields in array result
// const companyNames = companies.map(function(company) {
//   return `${company.name} [${company.start} to ${company.end}]`;
// });

// same as above using fat arrow
// const companyNames = companies.map(
//   company => `${company.name} [${company.start} to ${company.end}]`
// );
// console.log(companyNames);

// Map using ages array, get square of each age...
const ageSquared = ages.map(age => age * age);
console.log(ageSquared);

const ageSquareRoot = ages.map(age => Math.sqrt(age));
console.log(ageSquareRoot);

const ageSquareRootTimesTwo = ages
  .map(age => Math.sqrt(age))
  .map(age => age * 2);
console.log(ageSquareRootTimesTwo);

// sort
// reduce

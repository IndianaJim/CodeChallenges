// JS palindrome stuff

const isPalindrome = function(fwdString) {
  return (
    fwdString ===
    fwdString
      .split('')
      .reverse()
      .join('')
  );
};

console.log(isPalindrome('racecar'));
console.log(isPalindrome('boomerang'));

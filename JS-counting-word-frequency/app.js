// Counting word frequency
var div = document.querySelector('div');
var textInput = document.getElementById('textBoxId');
textInput.addEventListener('change', function(e) {
  div.innerHTML = e.target.value;
});

//textInput.textContent = 'this is a test';
console.log(textInput.textContent);

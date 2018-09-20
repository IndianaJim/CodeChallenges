// JS simple image slider

var i = 0; //image start index
var images = [];
var time = 2000;

// image list
images[0] = '1.jpg';
images[1] = '2.jpg';
images[2] = '3.jpg';

// function to change image
function changeImg() {
  document.slide.src = images[i];

  if (i < images.length - 1) {
    i++;
  } else {
    i = 0;
  }

  setTimeout('changeImg()', time);
}

window.onload = changeImg;

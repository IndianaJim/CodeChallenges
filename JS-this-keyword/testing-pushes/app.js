// JS this keyword

// method -> references the obj

const video = {
  title: 'a',
  play() {
    console.log(this);
  }
};

video.play();

video.stop = function() {
  console.log(this);
};
video.stop();

// ---------------------------------------
// function -> global (window, global)

function playVideo() {
  console.log(this);
}

playVideo();

function Video(title) {
  this.title = title;
  console.log(this);
}

const v = new Video('jim title');

//

const video1 = {
  title: 'd',
  tags: ['d', 'e', 'f'],
  showTags() {
    this.tags.forEach(function(tag) {
      console.log(this.title, tag);
    });
  }
};
video1.showTags();

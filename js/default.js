$(function () {
    setScrollToTop();
    $(window).resize(function () {
        setScrollToTop();
    })
    $(window).scroll(function () {
        setScrollToTop();
    })
    wow = new WOW(
      {
          animateClass: 'animated',
          offset: 100,
          callback: function (box) {
              console.log("WOW: animating <" + box.tagName.toLowerCase() + ">")
          }
      }
    );
    wow.init();
})
function setScrollToTop() {
    var top = $(window).scrollTop();
    if (top < 60) {
        $('#goTop').hide();
    } else {
        $('#goTop').show();
        console.log("show");
    }
    console.log("show");
}
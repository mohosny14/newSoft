$(".minuBar").click(function(){
    $(".navbar ul").slideToggle()
});


function myFunction(x) {
if (x.matches) {
$('.ourTeam_slidr').slick({
      slidesToShow: 2,
      slidesToScroll: 1,
      autoplay: true,
      autoplaySpeed: 2000,
    });

}else{
$('.ourTeam_slidr').slick({
      slidesToShow: 5,
      slidesToScroll: 1,
      autoplay: true,
      autoplaySpeed: 3000,
    });
}
}
    var x = window.matchMedia("(max-width: 600px)")
    myFunction(x) // Call listener function at run time
    x.addListener(myFunction) // Attach listener function on state changes
var GLOBAL = {

	temp : "abc",
	temp1 : 1,
	winWidth : $(window).width(),

	init:function()
	{
		//<!-- header footer site min height -->
			var contentheight = $(window).height() - $("header").height() - $("footer").height();
			$(".section_container").css("min-height", contentheight);
		//<!-- header footer site min height -->

		$(window).scroll(function(){
			if ($(this).scrollTop() > 100) {
				$('.scrollup').fadeIn();
			} else {
				$('.scrollup').fadeOut();
			}
		});

		$('.home_slider').slick({
			setting-name: setting-value
		});

		//Click event to scroll to top
		$('.scrollup').click(function(){
			$('html, body').animate({scrollTop : 0},800);
			return false;
		});
		GLOBAL.events();
		GLOBAL.wowScroller();
		$(window).load(function(){ GLOBAL.load(); });
		$(window).resize(function(){ GLOBAL.resize(); });
	},

	events: function()
	{



	},

	load:function()
	{

		// For Page GLOBAL
		window.scrollTo(0,0);
		$('.scrollup').fadeOut(300);
		$('#loading').fadeOut(300);


		// For Animation
		$(".header-wrapper").removeClass("for-animation");

	},

	resize:function()
	{



	}

};


var HOME = {

	init:function()
	{

		//alert(GLOBAL.winWidth);

		HOME.events();
		$(window).resize(function(){ HOME.resize(); });
		$(window).load(function(){ HOME.load(); });
	},

	events: function()
	{



	},

	resize:function()
	{



	},

	load:function()
	{



	}

}



























$(document).ready(function(){



	});

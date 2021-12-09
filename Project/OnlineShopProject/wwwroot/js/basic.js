/*
 * SimpleModal Basic Modal Dialog
 * http://simplemodal.com
 *
 * Copyright (c) 2013 Eric Martin - http://ericmmartin.com
 *
 * Licensed under the MIT license:
 *   http://www.opensource.org/licenses/mit-license.php
 */

jQuery(function ($) {
	// Load dialog on page load
	//$('#basic-modal-content').modal();
	
	$('.openIframeDetail').click(function (e) {
		e.preventDefault();
		//alert(src);
		var src = $(this).attr("href");
		//console.log(src);
		$.modal('<iframe class="cus-iframe-css" src="' + src + '"  style="border:0">', {
			closeHTML: "",
			containerCss: {
				backgroundColor: "#fff",
				borderColor: "#fff",
				height: 600,
				padding: 0,
				width: 1000
			},
			
			onShow: function (dialog) {
				dialog.container.css({ "height": "auto", "width": "auto" });
			},
			
			overlayClose: true
			//dialog.container.css({ "height": "auto", "width": "auto" });
		});
	});
	
});



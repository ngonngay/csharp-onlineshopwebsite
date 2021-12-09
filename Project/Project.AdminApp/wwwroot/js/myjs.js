jQuery(function ($) {
    $(document).on("submit", "form", function (event) {
        event.preventDefault();
        console.log("submit by js");
        var data = new FormData(this);
        $.ajax({
            url: $(this).attr("action"),
            type: $(this).attr("method"),
            dataType: "JSON",
            data: new FormData(this),
            processData: false,
            contentType: false,
            success: function (data, status) {
                console.log(data);
                window.parent.location.reload();
                window.close();
            },
            error: function (xhr, desc, err) {
                console.log("action: " + $(this).attr("action"));
                console.log("type: " + $(this).attr("method"));
                console.log(data);
            }
        });

    });
});
/*jQuery(function ($) {
    function adjustIframes() {
        $('iframe').each(function () {
            var
                $this = $(this),
                proportion = $this.data('proportion'),
                w = $this.attr('width'),
                actual_w = $this.width();

            if (!proportion) {
                proportion = $this.attr('height') / w;
                $this.data('proportion', proportion);
            }

            if (actual_w != w) {
                $this.css('height', Math.round(actual_w * proportion) + 'px');
            }
        });
    }
    $(window).on('resize load', adjustIframes);
});*/
jQuery(function ($) {
    $(".assignRequest").click(function (e) {
        event.preventDefault(); 
        var targetBtn = $(this);
        $.ajax({
            url: $(this).attr("href"),
            type: "Post",
            dataType: "JSON",
            data: "abbababab",
            processData: false,
            contentType: false,
            success: function (data, status) {
                
                if (data["result"]=="true") {
                    if (data["method"] == "assign") {
                        var href = targetBtn.attr("href");
                        href = href.replace('Assign', 'Unassign')
                        targetBtn.attr("class","btn btn-danger assignRequest unassign");
                        targetBtn.attr("href", href);
                        targetBtn.text("Bỏ Chọn Danh Mục");
                    } else {
                        var href = targetBtn.attr("href");
                        href = href.replace('Unassign', 'Assign')
                        targetBtn.attr("class","btn btn-primary assignRequest assign");
                        targetBtn.attr("href", href);
                        targetBtn.text("Chọn Danh Mục");
                        
                    }
                }
            },
            error: function (xhr, desc, err) {
                console.log("fuck");
            }
        });
        
    });
});

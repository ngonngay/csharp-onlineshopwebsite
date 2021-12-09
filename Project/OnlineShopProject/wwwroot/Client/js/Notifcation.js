var ManageNotifcationController = function () {
    this.initialize = function () {
        registerEvents();
    }

    function registerEvents() {
        $('body').on("click", ".notification--detail", function (e) {
            var id = $(this).data("id");
            updateStatus(id);
        });
        $('body').on("click", ".adelete-no", function (e) {
            e.preventDefault();
            var href = $(this).prop('href');
            var id = $(this).data("id");
           /* var strings = "#" + id;
            $(strings).hide();*/
            DeleteNotification(id, false);
        });
    }

    function updateStatus(noticationId) {
        $.ajax({
            type: "POST",
            url: "/User/UpdateNotificationStatus",
            data: {
                noticationId: noticationId,
                ApplyforAll:false
            },
            success: function (res) {
                console.log("success");
                console.log(res);
                if (res["result"] == "success") {
                    window.location.reload();
                } else {
                    console.log("false");
                }
            },
            error: function (err) {
                console.log(err);
                return false;
            }
        });
    }
    function DeleteNotification(noticationId,addplyforall) {
        $.ajax({
            type: "POST",
            url: "/User/DeleteNotification",
            data: {
                noticationId: noticationId,
                ApplyforAll: addplyforall
            },
            success: function (res) {
                console.log("success");
                console.log(res);
                window.location.reload();
                if (res["result"] == "success") {
                    window.location.reload();
                } else {
                    console.log("false");
                }
            },
            error: function (err) {
                console.log(err);
                return false;
            }
        });
    }


}
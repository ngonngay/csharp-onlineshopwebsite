var ManageImageAction = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }
    function registerEvents() {

        $('body').on('click', '.btn-remove-img', function (e) {
            e.preventDefault();
            const id = $("#productId").data('id');
            const imgId = $(this).data("imgid");
            /*console.log("productId=" + id);
            console.log("imgId=" + imgId);*/
            swal({
                title: "Bạn Chắc Chứ?",
                text: "Việc này sẽ bỏ ảnh này khỏi hệ thống!",
                icon: "warning",
                buttons: true,
                dangerMode: true,
            }).then((willDelete) => {
                if (willDelete) {
                    removeImage(id, imgId);
                } else {
                    swal("Cảm ơn bạn!");
                }
            });

        });
        $('body').on('change', '.isDefault-e', function (e) {
            e.preventDefault();
            const id = $("#productId").data('id');
            const imgId = $(this).data("imgid");
            console.log("imgId=" + imgId);
            ChangeDefaultImage(id, imgId);
        });
    }
    function loadData() {
        const id = $("#productId").data('id');
        
        $.ajax({
            type: "GET",
            url: "/Products/GetListImage?productId="+id,
            success: function (res) {
                var html = 'Sản Phẩm chưa có ảnh';
                console.log(res);
                if (res.length != 0) {
                    html = "<thead><tr><th scope=\"col\">Ảnh<\/th><th scope=\"col\">Caption<\/th><th scope=\"col\">Số ưu tiên<\/th><th scope=\"col\">Đặt làm đại diện<\/th><th scope=\"col\">Xóa<\/th><\/tr><\/thead>";

                    $.each(res, function (i, item) {
                        var checked = item.isDefault ?"checked=\"checked\"":"";
                        var classChecked = item.isDefault ? "ischecked" : "unchecked";
                        html += "<tr>"
                            + "<td class=\"w-25 h-25\">"
                            + "<img style=\"display:block;width: 175px; height: 230px; object-fit: cover;\" src='" + item.imagePath + "' alt=\"Alternate Text\" \/><\/td>"
                            + "<td style=\"vertical-align: middle;text-align: center;\">"
                            + "<div >" + item.caption + "<\/div><\/td>"
                            + "<td style=\"vertical-align: middle;text-align: center;\">"
                            + "<div>" + item.sortOrder + "<\/div><\/td>"
                            + "<td style=\"margin:50%;\"><input " + checked + "class=\"isDefault-e " + classChecked + "\" data-val=\"true\" data-imgid=" + item.id + " data-val-required=\"The IsDefault field is required.\" id=\"item_IsDefault\" name=\"item.IsDefault\" style=\"margin:50%;width:20px;height:20px;\" type=\"checkbox\" value=\"true\"><\/td>"
                            + "<td style=\"vertical-align: middle;text-align: center;\">"
                            + "<button data-imgId=\""+item.id +"\" class=\"btn-remove-img manageImage\"><i class=\"fa fa-trash\"><\/i><\/button><\/td>"
                            + "<\/tr>";
                    });
                }
                $('#manageImage').html(html);
            }
        });
    }
    async function removeImage(id, imgId) {
        /*console.log("productId=" + id);
        console.log("imgId=" + imgId);*/
        $.ajax({
            type: "POST",
            url: "/Products/RemoveImg",
            data: {
                productId: id,
                imgId: imgId
            },
            success: function (res) {
                /*console.log("success");
                console.log(res);*/
                if (res["result"]=="success") {
                    swal("Đã xóa ảnh này!", {
                        icon: "success",
                    });
                    loadData();
                } else {
                    swal("Đã Có Lỗi!Vui Lòng Thử Lại!", {
                        icon: "warning",
                    });
                }
            },
            error: function (err) {
                console.log(err);
                return false;
            }
        });
    }
    function ChangeDefaultImage(id, imgId) {
        $.ajax({
            type: "POST",
            url: "/Products/ChangeDefaultImage",
            data: {
                productId: id,
                imgId: imgId
            },
            success: function (res) {
                console.log(res);
            },
            error: function (err) {
                console.log(err);
                return false;
            }
        });
    }
}
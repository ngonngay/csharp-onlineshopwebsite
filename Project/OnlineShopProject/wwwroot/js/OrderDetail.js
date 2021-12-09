var OrderDetailController = function () {
    this.initialize = function () {
        
        registerEvents();
    }
    function registerEvents() {
        
        $('body').on('change', 'select#status', function (e) {
            e.preventDefault();
            var selectedStatus = $(this).children("option:selected").val();
            if (selectedStatus == 5) {
                $("#wrapReason").show();
            } else {
                $("#wrapReason").hide();
            }
        });
        $('body').on('change', 'select#reason', function (e) {
            e.preventDefault();
            $("#reason").removeClass("border-danger");
        });
        $('body').on('click', '#saveOrder', function (e) {
            e.preventDefault();
            var OrderId = $(this).data("id");
            var selectedStatus = $("select#status").children("option:selected").val();
            //console.log(selectedStatus);
            if (selectedStatus == 5) {
                var reason = $("#reason").children("option:selected").val();
                
                console.log(reason);
                if (reason == "null") {
                    $("#reason").addClass("border-danger");
                } else {
                    /*swal({
                        title: "Good job!",
                        text: "You clicked the button!",
                        icon: "success",
                    });*/
                    //console.log(OrderId, selectedStatus, reason);
                    UpdateStatusR(OrderId, selectedStatus, reason);
                }
            }
            UpdateStatus(OrderId, selectedStatus);
        });

    }
    function UpdateStatusR(OrderId, selectedStatus, reason) {
        $.ajax({
            type: "POST",
            url: "/Sale/UpdateOrderStatus",
            data: {
                OrderId: OrderId,
                selectedStatus: selectedStatus,
                reason: reason
               
            },
            success: function (res) {
                /*console.log("success");
                console.log(res);*/
                if (res["result"] == "success") {
                    console.log("test1");
                    swal("Cập nhật thành công!", {
                        icon: "success",
                    });
                   
                } else {
                    console.log("test");
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
    function UpdateStatus(OrderId, selectedStatus) {
        $.ajax({
            type: "POST",
            url: "/Sale/UpdateOrderStatus",
            data: {
                OrderId: OrderId,
                selectedStatus: selectedStatus,
                
            },
            success: function (res) {
                /*console.log("success");
                console.log(res);*/
                if (res["result"] == "success") {
                    swal("Cập nhật thành công!", {
                        icon: "success",
                    });
                    
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
   
}
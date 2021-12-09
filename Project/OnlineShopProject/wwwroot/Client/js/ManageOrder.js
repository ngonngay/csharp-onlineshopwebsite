var ManageOrderController = function () {
    this.initialize = function () {
       
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.cancle-order', function (e) {
            e.preventDefault();
            var status = $(this).data("status");
            //console.log(status);
            if (status=="Shipping"||status=="shipping") {
                Swal.fire({
                    icon: 'error',
                    html: 'Không thể hủy đơn hàng, Đơn hàng này đang được giao đến bạn. Vui lòng gọi hỗ trợ để được trợ giúp!'
                });
            } else {
                Swal.fire({
                    title: 'Chọn Lý Do Hủy Đơn Hàng',
                    input: 'select',
                    inputOptions: {
                        'Không còn nhu cầu': 'Không còn nhu cầu',
                        'Thêm sản phẩm': 'Thêm sản phẩm',
                        'Chọn nhầm sản phẩm': 'Chọn nhầm sản phẩm',
                        'Xử lí đơn hàng chậm': 'Xử lí đơn hàng chậm',
                        'Đỏi sản phẩm': 'Đỏi sản phẩm',
                        'Khác': 'Khác',
                    },
                    inputPlaceholder: '--Chọn Lý Do--',
                    showCancelButton: true,
                    inputValidator: function (value) {
                        return new Promise(function (resolve, reject) {
                            if (value !== '') {
                                resolve();
                            } else {
                                resolve('Hãy Chọn Lý Do Hủy Đơn!');
                            }
                        });
                    }
                }).then(function (result) {
                    var reason = result.value;
                    if (result.isConfirmed) {
                        if (result.value != "Khác") {
                            const id = $(".id").data("id");
                            console.log(id);
                            updateStatus(id, result.value);
                        } else {
                            Swal.fire({
                                title: 'Lý do bạn hủy đơn hàng là gì?',
                                input: 'text',
                                inputAttributes: {
                                    autocapitalize: 'off'
                                },
                                inputPlaceholder: 'Hãy cho chúng tôi biết vấn đề của bạn',
                                showCancelButton: true,
                                inputValidator: function (value) {
                                    return new Promise(function (resolve, reject) {
                                        if (value !== '') {
                                            resolve();
                                        } else {
                                            resolve('Hãy Nhập Lý Do Của Bạn');
                                        }
                                    });
                                }
                            }).then(function (result2) {
                                if (result2.isConfirmed) {
                                    reason += " " + result2.value;
                                    const id = $(".id").data("id");
                                    console.log(id);
                                    updateStatus(id, reason);
                                }
                            });
                        }
                    }
                });
            }
           
        });
    }

    function updateStatus(orderId, reason) {
        //console.log("test");
        $.ajax({
            type: "POST",
            url: "/Sale/UpdateOrderStatus",
            data: {
                OrderId: orderId,
                selectedStatus: 5,
                reason: reason,
                
            },
            success: function (res) {
                /*console.log("success");
                console.log(res);*/
                if (res["result"] == "success") {

                    Swal.fire({
                        icon: 'success',
                        html: "Hủy Đơn Hàng Thành Công"
                    });
                    location.reload();
                } else {
                    Swal.fire({
                        icon: 'error',
                        html: 'Đã có lỗi xảy ra!\n Hãy liên lạc qua số 0328025122 để được hỗ trợ!'
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
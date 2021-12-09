// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var SiteController = function () {
    this.initialize = function () {
        regsiterEvents();
        loadCart();
        setInterval(loadNews(), 1000);
    }
    function loadCart() {
       // console.log("loading cart....");
        
            $.ajax({
                type: "GET",
                url: "/Cart/GetListItems",
                success: function (res) {
                    //console.log(res)
                    $('#lbl_number_of_items').text("(" + res.length + ")");
                }
            });
        
       
    }
    function loadNews() {
        //console.log("loading news....");
        var isSigned = $("#is-signed-in").data("signed");
        //console.log(isSigned);
        if (isSigned == "true" || isSigned == true) {
            $.ajax({
                type: "GET",
                url: "/User/GetNotification",
                success: function (res) {
                    $(".news").text(" (" + res.length + ")");
                    $("#nav-news").text(" (" + res.length + ")");

                }
            });
        }
       
    }
    function regsiterEvents() {
        // Write your JavaScript code.
        //console.log("add to cart......checked");
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            var productId = $(this).data('id');
            var size = $(".btn-active").data('size');
            var quantity = $("#quantity").val();
            console.log(quantity);
            if (size == "null"||size==null) {
                Swal.fire({
                    title: 'Chọn size nào <3',
                    input: 'select',
                    inputOptions: {
                        'S': 'Size S',
                        'M': 'Size M',
                        'L': 'Size L',
                        'XL': 'Size XL'
                    },
                    inputPlaceholder: 'Chọn size sản phẩm',
                    showCancelButton: true,
                    inputValidator: function (value) {
                        return new Promise(function (resolve, reject) {
                            if (value !== '') {
                                resolve();
                            } else {
                                resolve('Bạn cần chọn Size trước khi hoàn tất bước này');
                            }
                        });
                    }
                }).then(function (result) {
                    if (result.isConfirmed) {
                        $.ajax({
                            type: "POST",
                            url: "/Cart/AddToCart",
                            data: {
                                id: productId,
                                size: result.value,
                                quantity:quantity
                            },
                            success: function (res) {
                                $('#lbl_number_of_items').text("(" + res.length + ")");
                                Swal.fire({
                                    icon: 'success',
                                    html: "Thêm vào giỏ hàng thành công"
                                });
                            },
                            error: function (err) {
                                console.log(err);
                            }
                        });

                    }
                });
            } else {
                //console.log(size,id);
                $.ajax({
                    type: "POST",
                    url: "/Cart/AddToCart",
                    data: {
                        id: productId,
                        size: size,
                        quantity: quantity
                    },
                    success: function (res) {
                        $('#lbl_number_of_items').text("(" + res.length + ")");
                        
                        Swal.fire({
                            title: "Đã Thêm Vào Giỏ Hàng!",
                            text: "Tiếp Tục Mua Sắm Nào!",
                            icon: "success",
                            button: "Oki!"
                        });
                    },
                    error: function (err) {
                        console.log(err);
                    }
                });
            }
            
        });
        $('body').on('click', '.icon-add-cart', function (e) {
            e.preventDefault();
            var productId = $(this).data('id');
            //var quantity = $("#quantity").val();
            //console.log(productId);
            Swal.fire({
                title: 'Chọn size nào <3',
                input: 'select',
                inputOptions: {
                    'S': 'Size S',
                    'M': 'Size M',
                    'L': 'Size L',
                    'XL': 'Size XL'
                },
                inputPlaceholder: 'Chọn size sản phẩm',
                showCancelButton: true,
                inputValidator: function (value) {
                    return new Promise(function (resolve, reject) {
                        if (value !== '') {
                            resolve();
                        } else {
                            resolve('Bạn cần chọn Size trước khi hoàn tất bước này');
                        }
                    });
                }
            }).then(function (result) {
                if (result.isConfirmed) {
                    $.ajax({
                        type: "POST",
                        url: "/Cart/AddToCart",
                        data: {
                            id: productId,
                            size: result.value
                        },
                        success: function (res) {
                            $('#lbl_number_of_items').text("(" + res.length + ")");
                            Swal.fire({
                                icon: 'success',
                                html: "Thêm vào giỏ hàng thành công"
                            });
                        },
                        error: function (err) {
                            console.log(err);
                        }
                    });
                   
                }
            });
        });
        $('body').on('click', '.size', function (e) {
            var button = $(this);
            var button_active = $(".btn-active");
            button_active.removeClass("btn-active");
            button.addClass("btn-active")
            var value = button.data('size');
            ///console.log(value);
            $("#addCart").attr("data-size", value);

        })
    }
}


function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}
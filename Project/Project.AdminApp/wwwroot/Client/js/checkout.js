var CheckoutController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '#CreateOrder', function (e) {
            e.preventDefault();
            createOder();
        });
    }

    function createOder(id, quantity) {

        $.ajax({
            type: "POST",
            url: "/Cart/CreateOrder",
            
            success: function (res) {
                
                swal.fire({
                    icon: "success",
                    html: "Tiếp tục mua sắm thôi!"
                }).then((willDelete) => {
                    window.location = "/";
                });
                
            },
            error: function (err) {
                console.log(err);
            }
        });
    }
    function loadData() {
        $.ajax({
            type: "GET",
            url: "/Cart/GetListItems",
            success: function (res) {
                var html = 'Bạn Chưa Có Sản Phẩm Nào Trong Giỏ Hàng';
                var total = 0;
                if (res.length != 0) {
                    
                    html = "<thead ><tr><th>Sản Phẩm<\/th><th>Giá<\/th><th>Số Lượng<\/th><th>Tổng<\/th><\/tr><\/thead><tbody class=\"align-middle\">";
                    var quantity = 0;
                    $.each(res, function (i, item) {
                        var amount = item.price * item.quantity;
                        quantity += item.quantity;
                        html += "<tr>"
                            + "<td><div class=\"img d-inline-flex align-items-center\"><a href=\"#\"><img class=\"checkoutimg\" src=\"" + item.image + "\" alt=\"Image\"><\/a><p>" + item.name + " - " + item.size + "<\/p><\/div><\/td>"
                            + "<td>" + numberWithCommas(item.price) + "<\/td>"
                            + "<td><div class=\"qty\">"
                            + "<input class=\"border-0\"  type=\"text\" value=\"" + item.quantity + "\" readonly/>"
                            + "<td>" + numberWithCommas(amount) + "<\/td>"
                            + "<\/tr>"
                            + "<\/tbody>";
                        total += amount;
                    });
                }
                
                $('#cart-detail').html(html);
                $('#lbl_number_of_items').text(res.length);
                $('#amount').text(quantity);
                $('#lbl_total').text(numberWithCommas(total));
                $('#lbl_grandTotal').text(numberWithCommas(total));
            }
        });
    }
}
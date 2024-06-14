// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    showQuantiyCart();
});

$(".addtocart").click(function (evt) {
  
    evt.preventDefault();
    let id = $(this).attr("data-productId");   
    $.ajax({
        url: "/KhachHang/Cart/AddToCartAPI",
        data: { "productId": id },
        success: function (data) {         
            Swal.fire({
                title: "Da them vao gio",
                text: "You clicked the button!",
                icon: "success"
            });
            showQuantiyCart();
        }
    });
})

let showQuantiyCart = () => {
    $.ajax({
        url: "/KhachHang/Cart/GetQuantiyOfCart",
        success: function (data) {
            $(".showcart").text(data.qty);
        }
    });
}

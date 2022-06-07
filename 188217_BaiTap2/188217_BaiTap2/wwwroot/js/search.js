

$(document).ready(function() {
    $('#search').on('keyup', function () {
        var SearchValue = $('#search').val();

        $.ajax({
            type: "post",
            url: "/home/GetSearchingData?SearchValue=" + SearchValue,
            success: function (result) {
                $('#result').html("");

                if (result.length == 0) {
                    $('#result').append("<tr><h3>Không có sản phẩm nào phù hợp</h3></tr>");
                }
                else {
                    $.each(result, function (index, value) {
                        var data = "<li> <a href='https://localhost:44354/san-pham/id-?id=" + value.productId + "'> <img src='../" + value.product_Img8 + "' width='70px' height= '70px'/><div class='result-content'><h5>" + value.product_Name + "</h5><div><span class='result-price'>" + value.product_Price + "đ</span><span class='result-price-old'>" + value.product_Price_Old + "đ</span><span class='result-price-percent'>" + value.product_Price_Percent + "%</span></div></div></a></li>";
                        $('#result').append(data);


                    });
                }
            }
        });
    });
});
    


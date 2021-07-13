/// <reference path="jquery-1.11.3.min.js" />
//文档就绪函数
$(function () {
    //1.获取注册按钮，点击事件
    $("#myreg").click(function () {
        //2.获取用户名和密码等注册信息
        var name = $("#username").val();
        var pwd = $("#password").val();
        var email=$("#email").val();
        var chname=$("#chname").val();
        var phone=$("#phone").val();
        var sex = $('input:radio[name="gender"]:checked').val();
        var birth = $('input:radio[name="birth"]:checked').val();

        //alert(sex);
        //3.调用get方法和数据库交互
        $.get("register.ashx", $("form").serialize(), function (back) {
            if (back == "ok") {
                alert("亲，注册成功！");
            }
            else {
                alert("亲，注册失败！");
            }
        });
    });
});
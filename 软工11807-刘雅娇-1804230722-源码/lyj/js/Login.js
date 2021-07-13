$(function(){
	$("#mybtn").click(function(){
		var username=$("#username").val();
		var userpwd=$("#inputPassword3").val();
		$.get("",{username:username,userpwd:userpwd},function(data){
			if(data=="1")
			{
				alert("登录成功！");
			}
			else
			{
				alert("登录失败！");
			}
		});
	});
});

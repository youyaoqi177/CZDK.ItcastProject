<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserInfo.aspx.cs" Inherits="CZDK.ItcastProject.WebApp.aspx.AddUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="../bootstrap-3.3.7/bootstrap.min.css" />
    <script src="../js/jquery-3.3.1.min.js"></script>
    <script src="../bootstrap-3.3.7/bootstrap.min.js"></script>
    <title>添加用户</title>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div style="width: 300px">
                <label for="txtName">用户名</label><input type="text" name="txtName" class="form-control" /><br />
                <label for="txtPwd">密码</label><input type="password" name="txtPwd" class="form-control" /><br />
                <label for="txtEmail">邮箱</label><input type="text" name="txtEmail" class="form-control" /><br />
                <input type="submit" value="添加用户" class="form-control" />
                <input type="hidden" name="isPostBack" value="aaa" />
                <a href="UserInfoList.aspx">
                    <input type="button" value="取消" class="form-control" />
                </a>

            </div>
        </form>
    </div>
</body>
</html>

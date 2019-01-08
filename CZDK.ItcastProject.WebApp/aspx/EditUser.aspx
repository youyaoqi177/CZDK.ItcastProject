<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="CZDK.ItcastProject.WebApp.aspx.EditUser" %>

<%@ Import Namespace="CZDK.ItcastProject.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="../bootstrap-3.3.7/bootstrap.min.css" />
    <script src="../js/jquery-3.3.1.min.js"></script>
    <script src="../bootstrap-3.3.7/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <div class="container">
        <div style="width: 300px">
            <form id="form1" runat="server">
                <label for="txtName">用户名</label><input type="text" name="txtName" class="form-control" value="<%=Info.UserName%>" /><br />
                <label for="txtPwd">密码</label><input type="text" name="txtPwd" class="form-control" value="<%=Info.UserPass %>" /><br />
                <label for="txtEmail">邮箱</label><input type="text" name="txtEmail" class="form-control" value="<%=Info.Email %>" /><br />
                <input type="hidden" name="txtId" value="<%=Info.Id %>" />
                <input type="submit" value="修改用户" class="form-control" />
            </form>
        </div>
    </div>


</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoList.aspx.cs" Inherits="CZDK.ItcastProject.WebApp.aspx.UserInfoList" %>

<%@ Import Namespace="CZDK.ItcastProject.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="../bootstrap-3.3.7/bootstrap.min.css" />
    <script src="../js/jquery-3.3.1.min.js"></script>
    <script src="../bootstrap-3.3.7/bootstrap.min.js"></script>
    <script>
        $(function () {
            $(".dele").click(function () {
                if (!confirm("确定删除吗？")) {
                    return false;
                }
            });
        });
    </script>
    <title>显示用户信息</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <a href="AddUserInfo.aspx">添加信息</a><br />
            <table class="table table-bordered table-striped">
                <tr>
                    <th>编号</th>
                    <th>用户名</th>
                    <th>密码</th>
                    <th>邮箱</th>
                    <th>时间</th>
                    <th>删除</th>
                    <th>详细</th>
                    <th>编辑</th>
                </tr>
                <!--for循环遍历数据-->
                <%foreach (UserInfo userInfo in UserList)%>
                <% { %>
                <tr>
                    <td><%=userInfo.Id %></td>
                    <td><%=userInfo.UserName %></td>
                    <td><%=userInfo.UserPass %></td>
                    <td><%=userInfo.Email %></td>
                    <td><%=userInfo.RegTime.ToShortDateString() %></td>
                    <td><a href="DeleteUser.ashx?id=<%=userInfo.Id %>" class="dele">删除</a></td>
                    <td><a href="EditUser.aspx?uid=<%=userInfo.Id %>">编辑</a></td>
                </tr>
                <%} %>
            </table>
        </div>
    </form>
</body>
</html>

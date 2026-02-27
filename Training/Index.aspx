<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Training.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container mt-3">
                <h2>Stacked form</h2>
               
                    <div class="mb-3 mt-3">
                        <label>Name:</label>
                        <%--<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">--%>
                        <asp:TextBox runat="server" ID="txtName" CssClass="form-control" ></asp:TextBox>
                        
                    </div>
                   
                    <div class="mb-3 mt-3">
                        <label>Contact:</label>
                        <%--<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">--%>
                        <asp:TextBox runat="server" ID="txtContact" TextMode="Number" CssClass="form-control" ></asp:TextBox>
                    </div>
                   
                    <div class="mb-3 mt-3">
                        <label>Select City:</label>
                        <%--<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">--%>
                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCities">
                            <asp:ListItem>Select City</asp:ListItem>
                            <asp:ListItem>Kolhapur</asp:ListItem>
                            <asp:ListItem>Pune</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Delhi</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                   <asp:Button runat="server" CssClass="btn btn-outline-success" ID="btnSubmit" Text="Register Now" />
                    
              
            </div>
        </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Training.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-3">
     <h2>Register</h2>
    
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
             <label>Email:</label>
             <%--<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">--%>
             <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control" ></asp:TextBox>
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
        <asp:Button runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-outline-success" ID="btnSubmit" Text="Register Now" />
         
   
 </div>
</asp:Content>

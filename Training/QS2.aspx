<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="QS2.aspx.cs" Inherits="Training.QS2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
    <div class="row">
        <div class="col-md-8">
            <h3>User Details</h3>
            <div class="mb-3 mt-3">
                <label>Name:</label>
                <%--<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">--%>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>

            </div>

            <div class="mb-3 mt-3">
                <label>Contact:</label>
                <%--<input type="email" class="form-control" id="email" placeholder="Enter email" name="email">--%>
                <asp:TextBox runat="server" ID="txtContact" TextMode="Number" CssClass="form-control"></asp:TextBox>
            </div>

            
        </div>
    </div>
</div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/StoryVibe.Master" AutoEventWireup="true" CodeBehind="wfRegister.aspx.cs" Inherits="Web.wfRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid">
    <div class="form-header">
        SIGN UP
    </div>
<%--        <div class="g-signin2" data-onsuccess="onSignIn"></div>--%>
        <div class="form__field">
            <label for="login__username">
                <i class="fa-solid fa-user form-icons"></i><span class="hidden">Username</span></label>
            <asp:TextBox CssClass="form-input" ID="tbxUsername" placeholder="Username" runat="server" />
        </div>

        <div class="form__field">
            <label for="login__Email">
                <i class="fa-solid fa-at form-icons"></i><span class="hidden">Email</span></label>
            <asp:TextBox CssClass="form-input" ID="tbxEmail" placeholder="Email Address" runat="server" />
        </div>

        <div class="form__field">
            <label for="login__password">
                <i class="fa-solid fa-lock form-icons"></i><span class="hidden">Password</span></label>
            <asp:TextBox TextMode="Password" ID="tbxPassword" CssClass="form-input" placeholder="Password" runat="server" />
        </div>
        
        <div class="form__field">
            <label for="login__birthdate">
            <i class="fa-solid fa-cake-candles form-icons"></i><span class="hidden">birthDate</span></label>
            <asp:TextBox TextMode="Date" ID="tbxBirthDate" ForeColor="#999999" CssClass="form-input" runat="server" />
        </div>

        <div class="form__field">
            <asp:Button Text="SIGN UP" CssClass="primary-button" ID="btnRegister" OnClick="btnRegister_Click" runat="server" />
        </div>
        <asp:Label Text="" ID="lblErrMessage" runat="server" />


        <p class="text--center">already a member? <a class="nav-link" href="#">Log In now</a><i class="fa-solid fa-arrow-right"></i></p>

    </div>
</asp:Content>

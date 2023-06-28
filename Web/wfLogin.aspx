<%@ Page Title="" Language="C#" MasterPageFile="~/StoryVibe.Master" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="Web.wfLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--    <meta name="google-signin-client_id" content="YOUR_CLIENT_ID.apps.googleusercontent.com">--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid">
    <div class="form-header">
        LOG IN
    </div>
<%--        <div class="g-signin2" data-onsuccess="onSignIn"></div>--%>
        <div class="form__field">
            <label for="login__username">
                <i class="fa-solid fa-user form-icons"></i><span class="hidden">Username</span></label>
            <asp:TextBox CssClass="form-input" ID="tbxUsername" placeholder="Username" runat="server" />
        </div>

        <div class="form__field">
            <label for="login__password">
                <i class="fa-solid fa-lock form-icons"></i><span class="hidden">Password</span></label>
            <asp:TextBox TextMode="Password" ID="tbxPassword" CssClass="form-input" placeholder="Password" runat="server" />
        </div>

        <div class="form__field">
            <asp:Button Text="LOGIN" CssClass="primary-button" ID="btnLogin" OnClick="btnLogin_Click" runat="server" />
        </div>
        <asp:Label Text="" ID="lblErrMessage" runat="server" />


        <p class="text--center">Not a member? <a href="#">Sign up now</a><i class="fa-solid fa-arrow-right"></i></p>

    </div>

<%--    <script src="https://apis.google.com/js/platform.js" async defer></script>
    <script src="OAuth.js"></script>--%>
</asp:Content>

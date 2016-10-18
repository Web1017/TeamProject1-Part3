<%@ Page Title="Login | SignUp" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginSignUpPage.aspx.cs" Inherits="TeamProject1.LoginSignUpPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="loginDiv">
        <asp:TextBox runat="server" ID="usernameTextBox" placeholder="Username" required="true" TabIndex="0" CssClass="usernameTextBox"></asp:TextBox> 
        <asp:TextBox runat="server" ID="passwordTextBox" TextMode="Password" placeholder="Password" required="true" TabIndex="1" CssClass="passwordTextBox"></asp:TextBox>
        <asp:Button runat="server" ID="loginButton" Text="Login" TabIndex="2" CssClass="loginButton"/>
    </div>
    <div class="signupDiv">
        <asp:TextBox runat="server" ID="firstNameSignUpTextBox" placeholder="Firstname" required="true" TabIndex="3" CssClass="firstNameSignUpTextBox"></asp:TextBox>
        <asp:TextBox runat="server" ID="lastNameSignUpTextBox" placeholder="Lastname" required="true" TabIndex="4" CssClass="lastNameSignUpTextBox"></asp:TextBox>
        <asp:TextBox runat="server" ID="passwordSignUpTextBox" placeholder="Password" required="true" TabIndex="4" CssClass="passwordSignUpTextBox" TextMode="Password"></asp:TextBox>
        <asp:TextBox runat="server" ID="phoneSignUpTextBox" placeholder="Phone no." required="true" TabIndex="5" TextMode="Phone" CssClass="phoneSignUpTextBox"></asp:TextBox>
        <asp:TextBox runat="server" ID="emailSignUpTextBox" placeholder="Your email" required="true" TabIndex="6" TextMode="Email" CssClass="emailSignUpTextBox"></asp:TextBox>
        <asp:Button runat="server" ID="signUpButton" Text="Sign Up" TabIndex="2" CssClass="signUpButton"/>
        <asp:Button runat="server" ID="cancelButton" Text="Cancel" TabIndex="2" CssClass="cancelButton"/>
    </div>
</asp:Content>

<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="ASPages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpMainContent" Runat="Server">
    &nbsp;<br />
    <asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>
      <asp:Login ID="Login1" runat="server" CreateUserText="Sign Up for a New Account" CreateUserUrl="~/ASPages/SignUp.aspx" Height="150px" Width="600px" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
          <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
      </asp:Login>
      <br />
      <br />
      <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" Height="150px" Width="600px" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
        <MailDefinition Subject="Your New Password for my website"></MailDefinition>
          <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
      </asp:PasswordRecovery>
    </AnonymousTemplate>
    <LoggedInTemplate>
      You are already logged in.
    </LoggedInTemplate>
  </asp:LoginView>
  <asp:LoginStatus ID="LoginStatus1" runat="server" />
</asp:Content>


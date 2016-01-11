<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FileControl.ascx.cs" Inherits="Controls_FileControl" %>

         <h1>Upload an Image to View :</h1><br /><br />
        <asp:FileUpload ID="FileUpload1" runat="server" Font-Italic="False" Font-Size="25px" Height="40px" Width="400px"  CssClass="MyButton"/>
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" Font-Size="25px" Height="60px" Width="176px" class="MyButton"/>
        <br />
<asp:UpdateProgress ID="UpdateProgress1" runat="server">
</asp:UpdateProgress>
<br />
         <asp:Label ID="lblmessage" runat="server" />
        <br /><br />
        <asp:Image ID="imgDemo" runat="server" />
        <br /><br />

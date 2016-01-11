<%@ Page Title="File Upload" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FileUpload.aspx.cs" Inherits="ASPages_FileUpload" %>

<%@ Register Src="~/Controls/FileControl.ascx" TagPrefix="uc1" TagName="FileControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <uc1:FileControl runat="server" ID="FileControl" />
</asp:Content>


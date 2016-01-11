<%@ Page Title="Form With Validations" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FormWithValidation.aspx.cs" Inherits="ASPages_FormWithValidation" %>

<%@ Register Src="~/Controls/FormControl.ascx" TagPrefix="uc1" TagName="FormControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <uc1:FormControl runat="server" id="FormControl" />
</asp:Content>


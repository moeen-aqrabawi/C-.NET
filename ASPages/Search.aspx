<%@ Page Title="Cearch JSON/jQuery" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpMainContent" Runat="Server">

    <div id="searcharea" style="width: 600px">
	<h1><label for="search">live search</label></h1><br /><br />
	<input type="search" name="search" id="search" placeholder="name or info" style="width: 405px; height: 40px;" /> 
    </div>
    <br /><br />
    <div id="update" style="width: 600px">></div>
    <script src="../MyScrips/seachscript.js"></script>
</asp:Content>

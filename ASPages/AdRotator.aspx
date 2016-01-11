<%@ Page Title="Ad Rotator" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AdRotator.aspx.cs" Inherits="ASPages_AdRotator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpMainContent" Runat="Server">
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>   
             <asp:Label ID="AdHeader" runat="server" Text="Ads"></asp:Label>
             <br />
             <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Adverts.xml" OnAdCreated="Page_Load" BorderStyle="Groove" />
             <br />
             <asp:Label ID="Label1" runat="server" Text="Ads"></asp:Label>
             <asp:Timer ID="Timer1" runat="server" Interval="1500" OnTick="Timer1_Tick"/>
        </ContentTemplate>
    </asp:UpdatePanel>

    
</asp:Content>


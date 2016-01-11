<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FormControl.ascx.cs" Inherits="Controls_FormControl" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 40px;
    }
    .auto-style3 {
        margin-left: 0px;
    }
    .auto-style4 {
        width: 285px;
    }
    .auto-style5 {
        width: 200px;
        height: 23px;
    }
    .auto-style6 {
        width: 285px;
        height: 23px;
    }
    .auto-style7 {
        height: 23px;
    }
    .auto-style8 {
        width: 200px;
    }
    </style>

<script type="text/javascript">
  function validatePhoneNumbers(source, args)
  {
    var phoneHome = document.getElementById('<%= HomePhone.ClientID %>');
    if (phoneHome.value != '')
    {
      args.IsValid = true;
    }
    else
    {
      args.IsValid = false;
    }
  }
</script>


<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>

<div id="TableWrapper">
<form id="form1">
<table class="auto-style1" runat="server" id="FormTable">
    <tr>
        <td colspan="1" style="font-size: xx-large" class="auto-style8">&nbsp;</td> 
    </tr>

    <tr>
         <td colspan="3" style="font-size: xx-large">Form with Validation :</td>
    </tr>

    <tr>
        <td class="auto-style8" style="font-size: xx-large">Name</td>
        <td class="auto-style4">
            <asp:TextBox ID="Name" runat="server" CssClass="auto-style3" Font-Size="25px" Height="40px" Width="400px">
            </asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" CssClass="ErrorMessage" ErrorMessage="Enter your name" Font-Size="15px">*</asp:RequiredFieldValidator>
        </td>
    </tr>

   
    <tr>
       <td class="auto-style8" style="font-size: xx-large">Email Address</td>
        <td class="auto-style4">
            <asp:TextBox ID="Email" runat="server" Font-Size="25px" Height="40px" Width="400px"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Font-Size="15px" CssClass="ErrorMessage" ControlToValidate="Email" ErrorMessage="Enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Font-Size="15px" CssClass="ErrorMessage" runat="server" ControlToValidate="Email" ErrorMessage="Enter an email address">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5" style="font-size: xx-large">Repeat Email</td>
        <td class="auto-style6">
            <asp:TextBox ID="RepeatEmail" runat="server" Font-Size="25px" Height="40px" Width="400px"></asp:TextBox>
        </td>
        <td class="auto-style7">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RepeatEmail" ErrorMessage="Confirm the email address" Font-Size="15px" CssClass="ErrorMessage"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" Font-Size="15px" CssClass="ErrorMessage" runat="server" ControlToCompare="Email" ControlToValidate="RepeatEmail" ErrorMessage="Email dont match">*</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style8" style="font-size: xx-large">Phome</td>
        <td class="auto-style4">
            <asp:TextBox ID="HomePhone" runat="server" Font-Size="25px" Height="40px" Width="400px"></asp:TextBox>
        </td>
        <td rowspan="2">
            <asp:CustomValidator ID="CustomValidator1" Font-Size="15px" runat="server" ErrorMessage="Enter a phone number" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="validatePhoneNumbers" CssClass="ErrorMessage" Display="Dynamic">*</asp:CustomValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style8" style="font-size: xx-large"> Country</td>
        <td class="auto-style4">
           <asp:DropDownList ID="ddlLocation" runat="server" Font-Size="25px" Height="40px" Width="400px">        
        </asp:DropDownList>

        </td>
    </tr>
    <tr>
       <td class="auto-style8" style="font-size: xx-large">Message</td>
        <td class="auto-style4">
            <asp:TextBox ID="comments" runat="server" Font-Size="25px" Height="200px" Width="400px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Font-Size="15px" runat="server" ControlToValidate="comments"  CssClass="ErrorMessage" ErrorMessage="Enter a comment">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" Font-Bold="False" Font-Size="25px" Height="40px" Width="165px" CssClass="MyButton" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1"  Font-Size="15px" runat="server" CssClass="ErrorMessage" HeaderText="Please corrent the following errors :" ShowMessageBox="True" ShowSummary="False" />
        </td>
    </tr>
</table>
        </div>
<asp:Label ID="Message" runat="server" CssClass="Attention"
    Text="Message Sent" Visible="false" />
<p runat="server" id="MessageSentPara" visible="false"> Thank You for your message.</p>
    
</ContentTemplate>
    </asp:UpdatePanel>

<asp:UpdateProgress ID="UpdateProgress1" runat="server"
    AssociatedUpdatePanelID="UpdatePanel1">
    <ProgressTemplate>
        <div class="PleaseWait">
            Please Wait....
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>

<script type="text/javascript">
    $(function () {
        $('form').bind('submit', function () {
            if (Page_IsValid) {
                $('#TableWrapper').slideUp(3000);
            }
        });
    });
    function pageLoad()
    {
        $('.Attention').animate({ width: '600px' }, 3000).
        animate({ width: '100px' }, 3000).fadeOut('slow');
    }

</script>

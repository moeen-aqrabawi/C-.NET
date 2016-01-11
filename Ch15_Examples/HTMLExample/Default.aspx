<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="font-size: medium; color: #003300; background-color: #CCFF33">
<head runat="server">
    <title>HTML Controls Example</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #Text1 {
            z-index: 1;
            left: 10px;
            top: 1px;
            position: relative;
            width: 170px;
            margin-bottom: 1px;
        }
        #Text2 {
            z-index: 1;
            left: 14px;
            top: 2px;
            position: relative;
            width: 180px;
        }
        #Text3 {
            z-index: 1;
            left: 12px;
            top: 4px;
            position: relative;
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
        <h1>Computer Club Registration Form</h1>
        <h3 style="text-align: left">First name:<input id="txtFirst" 
            runat="server" type="text" /></h3>
        <h3 style="text-align: left">&nbsp;</h3>
        <h3 style="text-align: left">Last name:<input id="txtLast" 
            runat="server" type="text" /></h3>
        <h3 style="text-align: left">&nbsp;</h3>
        <h3 style="text-align: left">Email:<input id="txtEmail" 
            runat="server" type="text" /></h3>
        <p style="text-align: center">
            <asp:Button ID="btnSubmit" runat="server" style="position: relative; height: 26px;" 
                Text="Submit" OnClick="btnSubmit_Click" />  </p>

        <p style="text-align: center"> 
            &nbsp;</p>
        <p style="text-align: center">
    
        <img alt="" style="height: 22px;" src="Images/HAPPY.jpg" /></p>
        <p style="text-align: left">
            <asp:Label ID="lblOutput" runat="server" 
                style="position: relative; text-align: left" ForeColor="Red"></asp:Label>
        </p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: left">
            &nbsp;</p>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>

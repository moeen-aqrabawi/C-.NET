<%@ Page language="c#" Inherits="WebControls.WebForm1"  CodeFile="Default.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Computer Club</title>
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body text="#006600" bgColor="#ffffcc">
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id=dataGrid1 style="Z-INDEX: 100; LEFT: 589px; POSITION: absolute; TOP: 241px" runat="server" Width="198px" BorderColor="Yellow" BorderStyle="Groove" DataMember="memberTable" DataSource="<%# memberDS %>">
				<HeaderStyle BackColor="#FFFF80"></HeaderStyle>
			</asp:datagrid><asp:label id="lblMembers" style="Z-INDEX: 101; LEFT: 591px; POSITION: absolute; TOP: 206px"
				runat="server" Width="230px" Visible="False" Font-Size="Large">Current Members</asp:label><asp:label id="lblMsg" style="Z-INDEX: 102; LEFT: 282px; POSITION: absolute; TOP: 349px" runat="server"
				Width="387px">Click below to find out when the club meets next.</asp:label><asp:label id="Label2" style="Z-INDEX: 103; LEFT: 38px; POSITION: absolute; TOP: 62px" runat="server"
				Width="70px" Font-Size="Large">FirstName:</asp:label><asp:calendar id="Calendar1" style="Z-INDEX: 104; LEFT: 28px; POSITION: absolute; TOP: 216px"
				tabIndex="19" runat="server" Width="179px" SelectedDate="2007-09-27" Height="180px"></asp:calendar><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 38px; POSITION: absolute; TOP: 90px" runat="server"
				Font-Size="Large">LastName:</asp:label><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 38px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Size="Large">PhoneNumber:</asp:label><asp:textbox id="txtBxFname" style="Z-INDEX: 107; LEFT: 224px; POSITION: absolute; TOP: 72px"
				runat="server" Width="157px" Height="21px"></asp:textbox><asp:textbox id="txtBxLname" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 96px"
				tabIndex="1" runat="server" AutoPostBack="True" Width="157px" Height="23px"></asp:textbox><asp:textbox id="txtBxPhone" style="Z-INDEX: 109; LEFT: 224px; POSITION: absolute; TOP: 128px"
				tabIndex="2" runat="server" AutoPostBack="True"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 110; LEFT: 38px; POSITION: absolute; TOP: 151px" runat="server"
				Font-Size="Large">Student I.D.:</asp:label><asp:textbox id="txtBxID" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 160px" tabIndex="3"
				runat="server" AutoPostBack="True"></asp:textbox><asp:button id="btnSubmit" style="Z-INDEX: 112; LEFT: 371px; POSITION: absolute; TOP: 230px"
				tabIndex="8" runat="server" BorderStyle="Groove" Font-Bold="True" ForeColor="DarkGreen" Text="Submit Info" Width="108px" onclick="btnSubmit_Click"></asp:button><asp:label id="Label7" style="Z-INDEX: 113; LEFT: 156px; POSITION: absolute; TOP: 10px" runat="server"
				Width="656px" Font-Size="X-Large">Computer Club Inquiry Form</asp:label><asp:button id="btnMembers" style="Z-INDEX: 114; LEFT: 331px; POSITION: absolute; TOP: 281px"
				tabIndex="9" runat="server" Text="See Current Members" CausesValidation="False" Width="189px" onclick="btnShowMembers_Click"></asp:button><asp:label id="Label6" style="Z-INDEX: 115; LEFT: 471px; POSITION: absolute; TOP: 67px" runat="server"
				Width="115px" Font-Size="Medium">Classification</asp:label><asp:radiobutton id="radBtnFresSop" style="Z-INDEX: 116; LEFT: 458px; POSITION: absolute; TOP: 97px"
				tabIndex="4" runat="server" AutoPostBack="True" Text="Freshman/Sophomore" GroupName="Classif" oncheckedchanged="radioButton_CheckedChanged"></asp:radiobutton><asp:radiobutton id="radBtnJrSr" style="Z-INDEX: 117; LEFT: 458px; POSITION: absolute; TOP: 121px"
				tabIndex="5" runat="server" AutoPostBack="True" Text="Junior/Senior" GroupName="Classif" oncheckedchanged="radioButton_CheckedChanged"></asp:radiobutton><asp:radiobutton id="radBtnOther" style="Z-INDEX: 118; LEFT: 458px; POSITION: absolute; TOP: 146px"
				tabIndex="6" runat="server" AutoPostBack="True" Text="Other" GroupName="Classif" oncheckedchanged="radioButton_CheckedChanged"></asp:radiobutton><asp:label id="Label8" style="Z-INDEX: 119; LEFT: 640px; POSITION: absolute; TOP: 64px" runat="server"
				Width="190px" Font-Size="Medium">Special Interests</asp:label><asp:listbox id="lstBxInterests" style="Z-INDEX: 120; LEFT: 632px; POSITION: absolute; TOP: 88px"
				tabIndex="11" runat="server" Width="161px" Height="58px">
				<asp:ListItem Value="Programming Contest">Programming Contest</asp:ListItem>
				<asp:ListItem Value="Social Gatherings">Social Gatherings</asp:ListItem>
				<asp:ListItem Value="Ask a Techie">Ask a Techie</asp:ListItem>
				<asp:ListItem Value="Tutoring">Tutoring</asp:ListItem>
			</asp:listbox><asp:label id="lblSubmit" style="Z-INDEX: 121; LEFT: 42px; POSITION: absolute; TOP: 411px"
				runat="server" Width="524px" Font-Size="Medium" Height="35px" Font-Bold="True" ForeColor="#004000"></asp:label><asp:label id="lblClassif" style="Z-INDEX: 122; LEFT: 472px; POSITION: absolute; TOP: 176px"
				tabIndex="20" runat="server" Width="350px"></asp:label><asp:requiredfieldvalidator id="valRequiredField" style="Z-INDEX: 124; LEFT: 384px; POSITION: absolute; TOP: 72px"
				runat="server" Width="70px" ControlToValidate="txtBxFname" ErrorMessage="Required!"></asp:requiredfieldvalidator><asp:button id="Button1" style="Z-INDEX: 125; LEFT: 369px; POSITION: absolute; TOP: 373px" runat="server"
				Width="112px" Text="Next Meeting" CausesValidation="False" onclick="btnShowCalendar_Click"></asp:button></form>
	</body>
</HTML>

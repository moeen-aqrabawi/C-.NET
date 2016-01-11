<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCFF99">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="text-align: center">Computer Club Inquiry Form</h1>
        <h3>First Name:<asp:TextBox ID="txtBxFname" runat="server" Width="149px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" 
                style="z-index: 1; left: 448px; top: 74px; position: absolute; height: 22px; width: 128px" 
                Text="Classification:"></asp:Label>
            <asp:Label ID="Label2" runat="server" 
                style="z-index: 1; left: 700px; top: 70px; position: absolute; height: 23px" 
                Text="Special Interests:"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtBxFname" EnableClientScript="False" 
                ErrorMessage="Required!" ForeColor="Red">Required!</asp:RequiredFieldValidator>
        </h3>
        <h3>
            <asp:RadioButton ID="radBtnFresSop" runat="server" 
                style="z-index: 1; left: 417px; top: 111px; position: absolute; bottom: 418px;" 
                Text="Freshman/Sophomore" AutoPostBack="True" GroupName="Classif" 
                OnCheckedChanged="radButtons_CheckedChanged" />
            <br />
            Last Name:<asp:TextBox ID="txtBxLname" runat="server" 
                Width="149px" TabIndex="1"></asp:TextBox>
            <asp:RadioButton ID="radBtnJrSr" runat="server" 
                style="z-index: 1; left: 415px; top: 146px; position: absolute" 
                Text="Junior/Senior" AutoPostBack="True" GroupName="Classif" 
                OnCheckedChanged="radButtons_CheckedChanged" />
            <asp:ListBox ID="lstBxInterests" runat="server" 
                
                
                
                
                style="z-index: 1; left: 685px; top: 103px; position: absolute; width: 163px; height: 47px;">
                <asp:ListItem>Programming Contest</asp:ListItem>
                <asp:ListItem>Social Gatherings</asp:ListItem>
                <asp:ListItem>Ask a Techie</asp:ListItem>
                <asp:ListItem>Tutoring</asp:ListItem>
                <asp:ListItem>Mentoring</asp:ListItem>
                <asp:ListItem>Department Web Site</asp:ListItem>
            </asp:ListBox>
        </h3>
        <h3>
            <asp:RadioButton ID="radBtnOther" runat="server" 
                style="z-index: 1; left: 415px; top: 182px; position: absolute" 
                Text="Other" AutoPostBack="True" GroupName="Classif" 
                OnCheckedChanged="radButtons_CheckedChanged" />
            <br />
            Phone Number:<asp:TextBox ID="txtBxPhone" runat="server" TabIndex="2"></asp:TextBox>
            <asp:Label ID="lblMembers" runat="server" 
                style="z-index: 1; left: 693px; top: 236px; position: absolute; height: 24px; width: 154px" 
                Text="Current Members: " Visible="False"></asp:Label>
        </h3>
        <h3>
            <asp:Label ID="lblClassif" runat="server" 
                
                style="z-index: 1; left: 344px; top: 239px; position: absolute; height: 28px; width: 312px; font-size: medium;"></asp:Label>
            <br />
            Student I.D.:<asp:TextBox ID="txtBxID" runat="server" 
                TabIndex="3" 
                style="z-index: 1; top: 261px; position: absolute; height: 21px; left: 115px"></asp:TextBox>
        </h3>
    
    </div>
        <asp:Label ID="lblSubmit" runat="server" 
            style="z-index: 1; left: 48px; top: 550px; position: absolute"></asp:Label>
        <asp:Label ID="lblMsg" runat="server" 
            style="z-index: 1; left: 316px; top: 523px; position: absolute; height: 19px; width: 312px"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" 
            style="z-index: 1; left: 15px; top: 355px; 
            position: absolute; height: 188px; width: 259px" SelectedDate="2013-08-20">
        </asp:Calendar>
        <asp:Button ID="btnSubmit" runat="server" 
            style="z-index: 1; left: 393px; top: 353px; position: absolute; width: 90px; height: 24px; text-align: center" 
            Text="Submit Info" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnShowMembers" runat="server" 
            style="z-index: 1; left: 358px; top: 398px; position: absolute" 
            Text="See Current Members" OnClick="btnShowMembers_Click"  />
        <asp:Label ID="Label3" runat="server" 
            style="z-index: 1; left: 313px; top: 434px; position: absolute; height: 16px; width: 304px" 
            Text="Click below to see when the club meets next."></asp:Label>
        <asp:Button ID="btnShowNextMeeting" runat="server" 
            style="z-index: 1; left: 389px; top: 479px; position: absolute; height: 23px" 
            Text="Next Meeting" OnClick="btnShowNextMeeting_Click" />
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/App_Data/member.accdb" 
            DeleteCommand="DELETE FROM [memberTable] WHERE (([StudentID] = ?) OR ([StudentID] IS NULL AND ? IS NULL))" 
            InsertCommand="INSERT INTO [memberTable] ([LastName], [FirstName], [StudentID]) VALUES (?, ?, ?)" 
            SelectCommand="SELECT [LastName], [FirstName], [StudentID] FROM [memberTable] ORDER BY [LastName], [FirstName]" 
            UpdateCommand="UPDATE [memberTable] SET [LastName] = ?, [FirstName] = ? WHERE (([StudentID] = ?) OR ([StudentID] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="StudentID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="StudentID" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="StudentID" Type="String" />
            </UpdateParameters>
        </asp:AccessDataSource>
        <asp:GridView ID="grdViewMembers" runat="server" AllowSorting="True" 
            AutoGenerateColumns="False" DataKeyNames="StudentID" 
            DataSourceID="AccessDataSource1" 
            style="z-index: 1; left: 628px; top: 274px; position: absolute; height: 132px; width: 325px" 
            Visible="False">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" 
                    SortExpression="FirstName">
                <HeaderStyle BackColor="#FFFFC0" />
                </asp:BoundField>
                <asp:BoundField DataField="LastName" HeaderText="Last Name" 
                    SortExpression="LastName">
                <HeaderStyle BackColor="#FFFFC0" />
                </asp:BoundField>
                <asp:BoundField DataField="StudentID" HeaderText="Student I D" ReadOnly="True" 
                    SortExpression="StudentID">
                <HeaderStyle BackColor="#FFFFC0" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

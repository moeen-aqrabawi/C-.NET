<%@ Page Title="Students SQL" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="ASPages_Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="Student_ID" DataSourceID="SqlDataSource1">
        <AlternatingItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="Student_IDLabel" runat="server" Text='<%# Eval("Student_ID") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="LoginNameLabel" runat="server" Text='<%# Eval("LoginName") %>' />
                </td>
                <td>
                    <asp:Label ID="DateofBirthLabel" runat="server" Text='<%# Eval("DateofBirth") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="Student_IDLabel1" runat="server" Text='<%# Eval("Student_ID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LoginNameTextBox" runat="server" Text='<%# Bind("LoginName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DateofBirthTextBox" runat="server" Text='<%# Bind("DateofBirth") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="Student_IDTextBox" runat="server" Text='<%# Bind("Student_ID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="LoginNameTextBox" runat="server" Text='<%# Bind("LoginName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DateofBirthTextBox" runat="server" Text='<%# Bind("DateofBirth") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="Student_IDLabel" runat="server" Text='<%# Eval("Student_ID") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="LoginNameLabel" runat="server" Text='<%# Eval("LoginName") %>' />
                </td>
                <td>
                    <asp:Label ID="DateofBirthLabel" runat="server" Text='<%# Eval("DateofBirth") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                            <tr runat="server" style="">
                                <th runat="server">Student_ID</th>
                                <th runat="server">FirstName</th>
                                <th runat="server">LastName</th>
                                <th runat="server">LoginName</th>
                                <th runat="server">DateofBirth</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style=""></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="Student_IDLabel" runat="server" Text='<%# Eval("Student_ID") %>' />
                </td>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                </td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                </td>
                <td>
                    <asp:Label ID="LoginNameLabel" runat="server" Text='<%# Eval("LoginName") %>' />
                </td>
                <td>
                    <asp:Label ID="DateofBirthLabel" runat="server" Text='<%# Eval("DateofBirth") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=uffyqhm96j.database.windows.net;Initial Catalog=trios;User ID=trios;Password=Moeen12345678" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [students]"></asp:SqlDataSource>
</asp:Content>


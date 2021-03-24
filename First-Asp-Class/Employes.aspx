<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employes.aspx.cs" Inherits="First_Asp_Class.Employes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Employes </title>
    <style type="text/css">
        .auto-style2 {
            width: 151px;
        }
    </style>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th class="auto-style2">Id</th>
                <td>
                    <asp:TextBox ID="Textid" runat="server"></asp:TextBox>
                   
                    <asp:Button ID="btnsearch" runat="server" Text="Search" CssClass="btn btn-success" OnClick="btnsearch_Click"/>
                       
                </td>
                <td>
                    &nbsp;</td>

            </tr>
            <tr>
                <th class="auto-style2">Name</th>
                <td colspan="2">
                    <asp:TextBox ID="Textname" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <th class="auto-style2">Email</th>
                <td colspan="2">
                    <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th class="auto-style2">Address</th>
                <td colspan="2">
                    <asp:TextBox ID="Textaddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th class="auto-style2">PhoneNumber</th>
                <td colspan="2">
                    <asp:TextBox ID="Textphonenumber" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th class="auto-style2">Designation</th>
                <td colspan="2">
                    <asp:TextBox ID="Textdesignation" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th class="auto-style2">EmployeCode</th>
                <td colspan="2">
                    <asp:TextBox ID="Textemployecode" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2"> 
                    <asp:Button ID="btnsave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnsave_Click" /> 
                    <asp:Button ID="btnupdate" runat="server" Text="Update" CssClass="btn btn-info" /> 
                    <asp:Button ID="btndelete" runat="server" Text="Delete"  CssClass="btn btn-danger"/> 

                </td>

                <td> <asp:Label ID="LabelMsg" runat="server"> </asp:Label> </td>
            </tr>

            <tr class="text-center">
                <asp:GridView ID="EmployesGridView" runat="server"> </asp:GridView>
            </tr>
        </table>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>


</body>
</html>


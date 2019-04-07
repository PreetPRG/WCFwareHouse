<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WarehouseManagementServiceClient.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 243px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >  
        <div style="width:100%;" align="center">  
            <fieldset style="width:40%;">  
                <legend>Perform CRUD Operations using WCF</legend>  
                <table class="auto-style4">  
                     <tr>  
                        <td class="auto-style1">  
                            <br />
                            <br />
                            <br />
                            <br />
                            Enter Id For Which you want to Search data<br />
&nbsp;</td>  
                        <td class="auto-style1"> 
                            <br />
                            <br /> 
                            <br />
                            <br />
                            <asp:TextBox ID="TextBox7" runat="server" Height="25px" Width="75px" ></asp:TextBox>  
                            <br />
                            <br />
                            <asp:Label ID="Label7" runat="server" Visible="False"></asp:Label>
                            <br />
                            <br />
                            <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" Text="Search" Width="100px" />
                        </td>  

                         </tr>
                    <tr>  
                        <td class="auto-style2" colspan="2">  
                            <asp:Label ID="Label8" runat="server" Text="Warehouse CIty" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server" Visible="False"></asp:TextBox>
    </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3" colspan="2">  
                            <asp:Label ID="Label9" runat="server" Text="Warehouse Name" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox9" runat="server" Visible="False"></asp:TextBox>
    </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3" colspan="2">  
                            <asp:Label ID="Label10" runat="server" Text="Company Name" Visible="False"></asp:Label>
&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox10" runat="server" Visible="False"></asp:TextBox>
    </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3" colspan="2">  
                            <asp:Label ID="Label11" runat="server" Text="Item Name" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox11" runat="server" Visible="False"></asp:TextBox>
    </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3" colspan="2">  
                            <asp:Label ID="Label12" runat="server" Text="Quantity" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox12" runat="server" Visible="False"></asp:TextBox>
    </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3" colspan="2">  
                            <asp:Label ID="Label13" runat="server" Text="Location" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox13" runat="server" Visible="False"></asp:TextBox>
    </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3" colspan="2">  
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Update" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 29px" Text="Delete" Visible="False" />
                        </td>  
                    </tr>  

                    <tr>  
                        <td colspan="2">  
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Home" />
                        </td>  
                    </tr>  
                    <tr>  
                        <td colspan="2">  
                            <br />  
                        </td>  
                    </tr>  
                    <tr>  
                        <td colspan="2">  
                            &nbsp;</td>  
                            </tr>  
                    </table>  
            </fieldset>  
            
        </div>  
    </form>  

</body>

</html>

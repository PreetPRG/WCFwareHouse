<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="WarehouseManagementServiceClient.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 243px;
        }
        .auto-style3 {
            height: 35px;
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
                        <td class="auto-style3">  
                            <asp:Label ID="Label1" Visible="false" runat="server" Text="Warehouse City "></asp:Label>
    </td>  
                        <td class="auto-style6">  
                            <asp:TextBox ID="TextBox1" runat="server" Visible="false" Height="25px" Width="75px" ></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style3">  
                            <asp:Label ID="Label2" Visible="false" runat="server" Text="Warehouse Name "></asp:Label>
    </td>  
                        <td class="auto-style6">  
                            <asp:TextBox ID="TextBox2" Visible="false" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style3">  
                            <asp:Label ID="Label3" runat="server" Visible="false" Text="Company Name "></asp:Label>
    </td>  
                        <td class="auto-style6">  
                            <asp:TextBox ID="TextBox3" runat="server" Visible="false" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3">  
                            <asp:Label ID="Label4" runat="server" Visible="false" Text="Item Name "></asp:Label>
    </td>  
                        <td class="auto-style6">  
                            <asp:TextBox ID="TextBox4" runat="server" Visible="false" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="auto-style3">  
                            <asp:Label ID="Label5" runat="server" Visible="false" Text="Quantity "></asp:Label>
    </td>  
                        <td class="auto-style3">  
                            <asp:TextBox ID="TextBox5" Visible="false" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3">  
                            <asp:Label ID="Label6" runat="server" Visible="false" Text="Location "></asp:Label>
    </td>  
                        <td class="auto-style6">  
                            <asp:TextBox ID="TextBox6" runat="server" Visible="false" Height="25px" Width="81px"></asp:TextBox>  
                        </td>  
                    </tr>  

                    <tr>  
                        <td class="auto-style3">  
       
                            <asp:Label ID="Label8" runat="server"></asp:Label>
       
    </td>  
                        <td class="auto-style6">  
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Confirm Delete" />
                        </td>  
                    </tr>  
                    <tr>  
                        <td colspan="2">  
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Home" />
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
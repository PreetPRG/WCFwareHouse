<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="WarehouseManagementServiceClient.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    
    <form id="form1" runat="server">  
        <div style="width:100%;" align="center">  
            <fieldset style="width:40%;">  
                <legend>Perform CRUD Operations using WCF</legend>  
                <table style="width:100%;">  
                    
                    <tr>  
                        <td>  
    Warehouse City  
    </td>  
                        <td>  
                            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="75px" ></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td>  
    Warehouse Name  
    </td>  
                        <td>  
                            <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td>  
    Company Name  
    </td>  
                        <td>  
                            <asp:TextBox ID="TextBox3" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  

                    <tr>  
                        <td>  
    Item Name  
    </td>  
                        <td>  
                            <asp:TextBox ID="TextBox4" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td>  
    Quantity
    </td>  
                        <td>  
                            <asp:TextBox ID="TextBox5" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  

                    <tr>  
                        <td>  
    Location
    </td>  
                        <td>  
                            <asp:TextBox ID="TextBox6" runat="server" Height="25px" Width="75px"></asp:TextBox>  
                        </td>  
                    </tr>  

                    <tr>  
                        <td>  
       
    </td>  
                        <td class="style1">  
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Height="25px" Width="100px" />  
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                        </td>  
                    </tr>  
                    <tr>  
                        <td colspan="2">  
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Home" />
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

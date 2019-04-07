<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
<style>
#customers {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

#customers td, #customers th {
  border: 1px solid #ddd;
  padding: 8px;
}

#customers tr:nth-child(even){background-color: #f2f2f2;}

#customers tr:hover {background-color: #ddd;}

#customers th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #4CAF50;
  color: white;
}
</style>
</head>

<body>
<table id="customers">
	<%
		Warehouse[] ware = (Warehouse[])request.getAttribute("ware");
		%>
		<hr>
		<th>
				srNo
			</th>
			<th>
				warehouseCIty
			</th>
			<th>
				warehouseCIty
			</th>
			<th>
				companyName
			</th>
			<th>
				itemName
			</th>
			<th>
				quantity
			</th>
			<th>
				location
			</th>
		</hr>
		<%
		for(int i=0;i<ware.length;i++)
		{
			%>
			<tr>
			<%
			Integer srNo = ware[i].getSrNo();
			String warehouseCity = ware[i].getWarehouseCity();
			String warehouseName = ware[i].getWarehouseName();
			String companyName = ware[i].getCompanyName();
			String itemName = ware[i].getItemName();
			Integer quantity = ware[i].getQuantity();
			String location = ware[i].getLocation(); %>
			<td>
				<% out.print(srNo); %>  
			</td>
			<td>
				<% out.print(warehouseCity); %>  
			</td>
			<td>
				<% out.print(warehouseName); %>  
			</td>
			<td>
				<% out.print(companyName); %>  
			</td>
			<td>
				<% out.print(itemName); %>  
			</td>
			<td>
				<% out.print(quantity); %>  
			</td>
			<td>
				<% out.print(location); %>  
			</td>
							
				
			</tr>
			<%} %>		

	</table>
	
</body>
</html>
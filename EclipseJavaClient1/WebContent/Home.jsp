<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ page import="org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse" %>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Montserrat">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
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
body,h1,h2,h3,h4,h5,h6 {font-family: "Lato", sans-serif}
.w3-bar,h1,button {font-family: "Montserrat", sans-serif}
.fa-anchor,.fa-coffee {font-size:200px}
</style>
</head>

<body>
<div class="w3-top">
  <div class="w3-bar w3-red w3-card w3-left-align w3-large">
    <a class="w3-bar-item w3-button w3-hide-medium w3-hide-large w3-right w3-padding-large w3-hover-white w3-large w3-red" href="javascript:void(0);" onclick="myFunction()" title="Toggle Navigation Menu"><i class="fa fa-bars"></i></a>
    <a href="HomeServlet" class="w3-bar-item w3-button w3-hide-small w3-padding-large w3-hover-white">Home</a>
    <a href="/EclipseJavaClient1/Search.jsp" class="w3-bar-item w3-button w3-hide-small w3-padding-large w3-hover-white">Search Record</a>
    <a href="/EclipseJavaClient1/Update.jsp" class="w3-bar-item w3-button w3-hide-small w3-padding-large w3-hover-white">Update Record</a>
    <a href="/EclipseJavaClient1/Delete.jsp" class="w3-bar-item w3-button w3-hide-small w3-padding-large w3-hover-white">Delete Record</a>
    <a href="/EclipseJavaClient1/Insert.jsp" class="w3-bar-item w3-button w3-hide-small w3-padding-large w3-hover-white">Insert Record</a>
  </div>

  <!-- Navbar on small screens -->
  <div id="navDemo" class="w3-bar-block w3-white w3-hide w3-hide-large w3-hide-medium w3-large">
    <a href="#" class="w3-bar-item w3-button w3-padding-large">Link 1</a>
    <a href="#" class="w3-bar-item w3-button w3-padding-large">Link 2</a>
    <a href="#" class="w3-bar-item w3-button w3-padding-large">Link 3</a>
    <a href="#" class="w3-bar-item w3-button w3-padding-large">Link 4</a>
  </div>
</div>

<!-- Header -->
<header class="w3-container w3-red w3-center" style="padding:128px 16px">
  <h1 class="w3-margin w3-jumbo">THE WAREHOUSE MANAGEMENT SERVICE</h1>
  <!-- <p class="w3-xlarge">Template by w3.css</p>-->
  <!-- <button class="w3-button w3-black w3-padding-large w3-large w3-margin-top">Get Started</button>-->
</header>
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
	<br/>
	<br/>
	<div class="w3-container w3-black w3-center w3-opacity w3-padding-64">
    <h1 class="w3-margin w3-xlarge">Quote of the day: live life</h1>
</div>
	
</body>
</html>
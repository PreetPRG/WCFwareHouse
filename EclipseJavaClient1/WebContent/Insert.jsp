<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
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
<form action="DefaultServlet" method="post">
<table id="customers">
	<tr>
	<td>
        warehouseCity
        </td>
        <td>
        <input type="text" name="warehouseCity" id="warehouseCity" required>
        </td>
        </tr>
        <tr>
        <td>
        warehouseName
		</td>
		<td>
        <input type="text" name="warehouseName" id="warehouseName" required>
        </td>
        </tr>
        <tr>
        <td>
        companyName
        </td>
        <td>
        <input type="text" name="companyName" id="companyName" required>
        </td>
        </tr>
        <tr>
        <td>
        itemName
        </td>
        <td>
        <input type="text" name="itemName" id="itemName" required>
        </td>
        </tr>
        <tr>
        <td>
        quantity
        </td>
        <td>
        <input type="number" name="quantity" id="quantity" required>
        </td>
        </tr>
        <tr>
        <td>
        location
        </td>
        <td>
        <input type="text" name="location" id="location" required>
        </td>
        </tr>
        <tr>
        <td>
        <input type="Submit" name="Insert" value="Insert" id="submit"/>
        </td>
        <td></td>
        </tr>
      	</table>
        </form>
</body>
</html>
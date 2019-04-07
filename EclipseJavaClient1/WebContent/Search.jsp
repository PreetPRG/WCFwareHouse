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
<form action="SearchServlet" method="post">
<table id="customers">
	<tr>
		<td>
			Enter SrNo for which you want to Search Item
		</td>
		<td>
			<input type="number" name="srNo" id="srNo" required/>
		</td>
	</tr>
	<tr>
	<td>
		<input type="submit" value="Search" name="Search" id="Search" text="Search"/>
		</td>
	</tr>
</table>
</form>
</body>
</html>
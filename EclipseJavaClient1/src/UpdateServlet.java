

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.datacontract.schemas._2004._07.WarehouseManagementServiceApp1.Warehouse;
import org.tempuri.IService1Proxy;

/**
 * Servlet implementation class UpdateServlet
 */
@WebServlet("/UpdateServlet")
public class UpdateServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public UpdateServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		Integer srNo = Integer.parseInt(request.getParameter("srNo"));
		IService1Proxy proxy = new IService1Proxy();
		Warehouse ware = proxy.getDetailsById(srNo);
		request.setAttribute("ware", ware);
		RequestDispatcher rd = request.getRequestDispatcher("/Update1.jsp");
		rd.forward(request, response);
		
		
		/*
		
		String warehouseCity = (String)request.getParameter("warehouseCity");;
		//System.out.println(request.getParameter("warehouseCity"));
		String warehouseName = (String)request.getParameter("warehouseName");
		String companyName = (String)request.getParameter("companyName");
		String itemName = (String)request.getParameter("itemName");
		Integer quantity = Integer.parseInt(request.getParameter("quantity"));
		String location = (String)request.getParameter("location");
		//IService1Proxy proxy = new IService1Proxy();
		proxy.updateDetails(srNo,warehouseCity, warehouseName, companyName, itemName, quantity, location);
		RequestDispatcher rd = request.getRequestDispatcher("/HomeServlet");
		rd.forward(request, response);
		*/
	}

}

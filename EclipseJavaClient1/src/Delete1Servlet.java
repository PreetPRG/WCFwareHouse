

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.tempuri.IService1Proxy;

/**
 * Servlet implementation class Delete1Servlet
 */
@WebServlet("/Delete1Servlet")
public class Delete1Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Delete1Servlet() {
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
		/*String warehouseCity = (String)request.getParameter("warehouseCity");;
		//System.out.println(request.getParameter("warehouseCity"));
		String warehouseName = (String)request.getParameter("warehouseName");
		String companyName = (String)request.getParameter("companyName");
		String itemName = (String)request.getParameter("itemName");
		Integer quantity = Integer.parseInt(request.getParameter("quantity"));
		String location = (String)request.getParameter("location");*/
		IService1Proxy proxy = new IService1Proxy();
		proxy.deleteDetails(srNo);
		//proxy.in
		//response.Redirect("Default.jsp");
		RequestDispatcher rd = request.getRequestDispatcher("/HomeServlet");
		rd.forward(request, response);
	}

}

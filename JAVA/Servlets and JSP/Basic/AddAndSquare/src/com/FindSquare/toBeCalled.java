package com.FindSquare;

import java.io.IOException;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class toBeCalled extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException, ServletException {
		int val1 = Integer.parseInt(request.getParameter("num1"));
		int val2 = Integer.parseInt(request.getParameter("num2"));
		
		int sum = val1 + val2;
		
		/*  
		 * 	Dispatching the sum value from here to the main
		 *  Square Servlet which is going to calculate the 
		 *  square value of this sum and Display it on the 
		 *  user's screen.
		 *  
		 *  The value sending method works just like
		 *  creating and workin on a session.
		 */
		request.setAttribute("sum", sum);
		
		/*
		 * Using a RequestDispatcher object to forward our request.
		 * 
		 * The RequestDispatcher is actually an interface
		 * but by using the getRequestDispatcher method,
		 * we can use it as a class and implement it
		 * within the class body.
		 * 
		 * sq here is specified so that we can set it as the 
		 * url-pattern in the web.xml deployment file.
		 * Whenever the request will be sent through this
		 * url, the SquareServlet.java class will be invoked immediately.
		 */
		RequestDispatcher reqd = request.getRequestDispatcher("sq");
		reqd.forward(request, response);
	}
}

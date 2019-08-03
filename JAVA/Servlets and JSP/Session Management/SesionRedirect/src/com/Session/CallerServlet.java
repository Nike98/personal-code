package com.Session;

import java.io.IOException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

public class CallerServlet extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		int val1 = Integer.parseInt(request.getParameter("num1"));
		int val2 = Integer.parseInt(request.getParameter("num2"));
		
		int sum = val1 + val2;
		
		/*
		 * Here, the sum of the two numbers taken from
		 * the User is passed to the next Servlet by
		 * creating a session and redirecting the 
		 * User to a new URL
		 * 
		 * 	<< Creating a Session and Redirecting the User >>
		 */
		
		// Creating an HttpSession object and setting the attribute
		HttpSession session = request.getSession();
		session.setAttribute("sum", sum);
		
		// Sending a Redirect response
		response.sendRedirect("sq");
	}
}

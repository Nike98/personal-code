package com.Add;

import java.io.IOException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class CallerServlet extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		int val1 = Integer.parseInt(request.getParameter("num1"));
		int val2 = Integer.parseInt(request.getParameter("num2"));
		
		int sum = val1 + val2;
		
		/*
		 * Sending the new derived/re-written URL
		 * to the next servlet body to fetch the Square
		 * of the Sum that is derived.
		 * 
		 * This id done using the sendRedirect() method
		 * using the response object.
		 * 
		 * 	<< URL Re-writing >>
		 */
		
		response.sendRedirect("sq?s=" + sum);
	}
}

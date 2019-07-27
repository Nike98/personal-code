package com.addNum;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class UsingGET extends HttpServlet{
	
	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		int val1 = Integer.parseInt(request.getParameter("num1"));
		int val2 = Integer.parseInt(request.getParameter("num2"));
		
		// For printing data on the web Interface
		PrintWriter out = response.getWriter();
		
		int sum = val1 + val2;
		
		out.println("The Result = " + sum);
	}
}

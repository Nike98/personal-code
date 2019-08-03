package com.Add;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.lang.Math;

public class SqServlet extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		int ans = Integer.parseInt(request.getParameter("s"));
		
		PrintWriter out = response.getWriter();
		out.println("The Result = " + Math.pow(ans, 2));
	}
}

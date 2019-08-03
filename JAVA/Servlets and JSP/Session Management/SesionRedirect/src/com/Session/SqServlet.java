package com.Session;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

public class SqServlet extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		HttpSession session = request.getSession();
		int ans = (int) session.getAttribute("sum");
		ans *= ans;
		
		PrintWriter out = response.getWriter();
		out.println("<b>The Result = " + ans + "</b>");
	}
}

package com.FindSquare;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class SquareServlet extends HttpServlet {

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		
		/*
		 * The value passed in the toBeCalled class
		 * as a session object is caught here and 
		 * type casted to int (as it is an object reference).
		 * 
		 * Further then the square is calculated and
		 * printed on the screen.
		 */
		int square = (int) request.getAttribute("sum");
		
		square *= square;
		
		PrintWriter out = response.getWriter();
		out.println("The Square of the Added values = " + square);
	}
}

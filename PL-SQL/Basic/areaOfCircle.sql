/*
 * Write a Pl/SQL code to find the 
 * area of a circle for the value of 
 * radius given by user.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	radius number(5,2) := &radius;
	area number;
 
 pi constant number(3,2) := 3.14;		-- Setting the value of pi as a constant
 
 BEGIN
 
	area := pi * (radius * radius);
	
	dbms_output.put_line(chr(10) || 'The Area of the Circle is: ' || area);
 
 END;
 /
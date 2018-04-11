/*
 * This program creates a function on the 
 * SQL command line where the User enters
 * a number and the function calculates
 * the square of the entered number and
 * displays it.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
	-- Creating the FUNCTION
 CREATE OR REPLACE FUNCTION square_num(num in number) return number 
 AS
 BEGIN
	
	return num * num;
 
 END;
 /
 
	-- Calling the FUNCTION
DECLARE

	n number := &n;

BEGIN

	dbms_output.put_line(chr(10) || '==================================');
	dbms_output.put_line(chr(13) || ' Square of ' || n || ' enetered: ' || square_num(n));
	dbms_output.put_line(chr(13) || '==================================');

END;
/
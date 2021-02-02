/*
 * Write a Pl/SQL code to find the factorial of the given number.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	fact number := 1;				-- initalizing fact to 1
	num number := &num;				-- getting input from the user
	n number;
 
 BEGIN
 
	n := num;
	while num > 0
	loop
	
	-- Calculating the factorial
	fact := num * fact;
	num := num - 1;
	
	end loop;
	
	-- Printing
	dbms_output.put_line(chr(10) || 'The Factorial of ' || n || ' is : ' || fact);
 
 END;
 /
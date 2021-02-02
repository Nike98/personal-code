
/*
 * Write a function to calculate value of factorial of a number.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 -- Function to derive the Factorial of an entered Number 
 CREATE OR REPLACE FUNCTION factorial(num number) RETURN NUMBER
 AS
	
	i number;				-- Declaring the variables to be used
	fact number;
	
 BEGIN

	fact := 1;				-- Initializing the value of fact
	
	for i in 1..num loop			-- Will start i from 1 and run till the number(input)
		fact := fact * i;			-- Logic for calculating the Factorial
	end loop;
	
	return fact;
	
 END;
/
 
 DECLARE
 
	num number := &num;		-- variable to take the input from the User
 
 BEGIN
 
	dbms_output.put_line(chr(10) || ' The Factorial of the number ' || num || ' is: ' || factorial(num));
 
 END;
 /
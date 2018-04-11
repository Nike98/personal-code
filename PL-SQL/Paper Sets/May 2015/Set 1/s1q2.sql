/*
 * a) Write a PL/SQL block to accept a number from the user and print the Factorial of that number
 * b) Write a PL/SQL block to accept a string and print the Reverse of that String
 * c) || In a separate file ||
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
		-- Function to derive the Factorial of an entered Number
 
 CREATE OR REPLACE FUNCTION factorial(num number) return number
 AS
	
	i number;				-- Declaring the variables to be used
	fact number;
	
 BEGIN

	fact := 1;			-- Initializing the value of fact
	
	for i in 1..num loop			-- Will start i from 1 and run till the number(input)
		fact := fact * i;			-- Logic for calculating the Factorial
	end loop;
	
	return fact;
	
 END;
/

		-- Function to Reverse the String input by the USER
		
 CREATE OR REPLACE FUNCTION rev_str(str varchar2) return varchar2
 AS 
 
	rev varchar2(50);					-- Declaring the variables to be used in the function
	str_len number;

 BEGIN

	str_len := length(str);				-- Storing the Length of the entered string in str_len
	
	for i in reverse 1..str_len loop			-- Runs the For Loop in Reverse from the str_len to 1
		rev := rev || '' || substr(str, i, 1);		-- Retrieves the character one by one
	end loop;
	
	return rev;

 END;
/ 
		-- Main Declaration and Calling
 
 DECLARE
 
	fact number := &fact;				-- Declaring the variables to be used
	str varchar2(50) := '&str';
 
 BEGIN
 
	dbms_output.put_line(chr(10) || '####################################################' || chr(10));
	dbms_output.put_line(chr(9) || ' The Factorial of ' || fact || ' is : ' || factorial(fact));		-- Prints the Factorial
 
	dbms_output.put_line(chr(9) || ' The Rversed String is : ' || rev_str(str));			-- Prints the Reversed String
	dbms_output.put_line(chr(10) || '####################################################');
 
 END;
 /
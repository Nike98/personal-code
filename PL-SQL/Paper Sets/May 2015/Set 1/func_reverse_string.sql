
/*
 * Write a PS/SQL function to display reverse of a string.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;

 -- Function to Reverse the String input by the USER		
 CREATE OR REPLACE FUNCTION rev_str(str varchar2) return varchar2
 AS 
 
	rev varchar2(50);					-- Declaring the variables to be used in the function
	str_len number;

 BEGIN

	str_len := length(str);				-- Storing the Length of the entered string in str_len
	
	for i in reverse 1..str_len loop				-- Runs the For Loop in Reverse from the str_len to 1
		rev := rev || '' || substr(str, i, 1);		-- Retrieves the character one by one
	end loop;
	
	return rev;

 END;
/ 

 DECLARE
 
	str varchar2(50) := '&str';
 
 BEGIN
 
	dbms_output.put_line(chr(10) || ' The Reversed String is : ' || rev_str(str));
 
 END;
 /
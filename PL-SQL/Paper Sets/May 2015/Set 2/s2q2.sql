/*
 * a) Write a PL/SQL block to accept a number from the user and print the Sum of the digits.
 * b) Write a PL/SQL block to accept a string and check whether the String is Palindrome or not.
 * c) || In a separate file ||
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
		-- Function for the Sum of Digits
	
		
 CREATE OR REPLACE FUNCTION sum_of_digits(og_num number) RETURN number
 AS

		num_sum number;			-- Declaring the variables to be used to store the sum
		temp number;			-- Declaring a temporary variable to store the value of og_num
		

 BEGIN
		temp := og_num;
		num_sum := 0;			-- Initializing the value of sum
		
		WHILE temp > 0
		loop
		
			num_sum := num_sum + mod(temp, 10);
			temp := trunc(temp / 10);
		
		end loop;
		
		return num_sum;

 END;
 /
 
 
		-- Function to check whether the sting is Palindrome or not
		
CREATE OR REPLACE FUNCTION str_palindrome(str1 varchar2) return varchar2
AS

	rev varchar2(50);					-- Declaring the variables to be used in the function
	str_len number;						-- Variable to store the length of the String
	msg varchar2(50);					-- To store the message to be returned

BEGIN

	str_len := length(str1);				-- Storing the Length of the entered string in str_len
	
	for i in reverse 1..str_len loop			-- Runs the For Loop in Reverse from the str_len to 1
		rev := rev || '' || substr(str1, i, 1);		-- Retrieves the character one by one
	end loop;
	
	if str1 = rev then
		msg := ' is a Palindrome String.';
	else
		msg := ' is not a Palindrome String.';
	end if;
	
	return msg;

END;
/
 
 		-- Main Declaration and Calling
 
 DECLARE
 
	num number := &num;
	str varchar2(50) := '&str';
	
 BEGIN
 
	dbms_output.put_line(chr(10) || '####################################################' || chr(10));
	dbms_output.put_line(chr(9) || ' The Sum of the Digits = ' || sum_of_digits(num));		-- Prints the Sum of the Digits
	dbms_output.put_line(chr(9) || ' ' || str || str_palindrome(str));
	dbms_output.put_line(chr(10) || '####################################################');
 
 END;
 /
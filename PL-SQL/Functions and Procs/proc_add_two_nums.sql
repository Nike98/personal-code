
/*
 * Write a stored procedure that accepts two numbers and returns the addition of
 * passed values. Also, write the code to call your procedure.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 -- PROCEDURE Block
 CREATE OR REPLACE PROCEDURE add_num (num1 IN NUMBER, num2 IN NUMBER, res OUT NUMBER)
 IS
 BEGIN
	
		res := num1 + num2;
	
 END;
 /
 
 -- Caller Block
 DECLARE
 
	num1 number := &num1;			-- getting input for num1
	num2 number := &num2;			-- getting input for num2
	addition number;
 
 BEGIN
 
	add_num(num1, num2, addition);
	
	dbms_output.put_line(chr(10) || ' Addition of ' || num1 || ' and ' || num2 || ' is: ' || addition);
 
 END;
 /
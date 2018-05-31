
/*
 * Write a PL/SQL block to accept a number and check whether it's Odd or Even.
 * If it is Even, print the Square of it, otherwise print the Cube of it.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num number(2,0) := &num;			-- Initializing the Variable num and taking the input also
	ans number(5,0);
 
 BEGIN
 
	if mod(num, 2) = 0 then
	
		ans := num * num;
		dbms_output.put_line(chr(10) || ' The Number is Even');
		dbms_output.put_line(chr(10) || ' The Square of ' || num || ' = ' || ans);
		
	else
	
		ans := num * num * num;
		dbms_output.put_line(chr(10) || ' The Number is Odd');
		dbms_output.put_line(chr(10) || ' The Cube of ' || num || ' = ' || ans);
	
	end if;
 
 END;
 /
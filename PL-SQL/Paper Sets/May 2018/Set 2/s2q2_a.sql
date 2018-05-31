
/*
 * Write a PL/SQL block to accept a number and check whether it's 
 * positive or negative.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num number(2,0) := &num;			-- Initializing the Variable num and taking the input also
 
 BEGIN
 
	if num > 0 then
	
		dbms_output.put_line(chr(10) || ' It is a Positive Number');
	
	else
	
		dbms_output.put_line(chr(10) || ' It is a Negative Number');
	
	end if;
 
 END;
 /
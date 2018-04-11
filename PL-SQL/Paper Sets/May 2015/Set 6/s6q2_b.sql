
/*
 * b) Write PL/SQL to accept a number and check whether it is EVEN or ODD.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	num number := &num;					-- Declaring the variable to store the value and taking the input
 
 BEGIN
 
	dbms_output.put_line(chr(10) || '##########################################' || chr(10));
	
	if mod(num, 2) = 0 then
	
		dbms_output.put_line(chr(9) || ' It is an EVEN Number');
		
	else
	
		dbms_output.put_line(chr(9) || ' It is an ODD Number');
	
	end if;
	
	dbms_output.put_line(chr(10) || '##########################################');
 
 END;
 /
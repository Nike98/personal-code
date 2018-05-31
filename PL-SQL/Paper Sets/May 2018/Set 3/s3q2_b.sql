
/*
 * Write a PL/SQL block which prints first 3 Even Numbers.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	num number(2,0) := &num;			-- Initializing variable num and taking the input at the same time
	ans number(3,0);					-- To store the answer
 
 BEGIN
 
	dbms_output.put_line(chr(10) || ' The table of ' || num || ' is : ');
	
	for i in 1..10
	loop
	
		ans := num * i;
		
		dbms_output.put_line(chr(10) || ' ' || num || ' X ' || i || ' = ' || ans);
	
	end loop;
 
 END;
 /
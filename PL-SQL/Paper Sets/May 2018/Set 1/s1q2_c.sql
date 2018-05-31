
/*
 * Write a PL/SQL block to accept a number and print the Square of it.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num number(2,0) := &num;			-- Initializing the Variable num and taking the input also
 
 BEGIN
 
	dbms_output.put_line(chr(10) || ' The Square of ' || num || ' = ' || num * num);
 
 END;
 /
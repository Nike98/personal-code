/*
 * This program prints the Fibonacci
 *  Series for 10 lines.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num number;
	first number;
	second number;
	next number;
 
 BEGIN
 
	num := 10;
	first := 0;
	second := 1;
	
	dbms_output.put_line(first);
	dbms_output.put_line(second);
	
	for i in 3..num loop
		next := first + second;
		
		dbms_output.put_line(chr(13) || next);
		
		first := second;
		second := next;
	end loop;
 
 END;
 /
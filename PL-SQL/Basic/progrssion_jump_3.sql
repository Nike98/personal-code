/*
 * Write a program in PL/SQL to print 1st n numbers with 
 * a difference of 3 and starting from 1.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	n number := &length;
	i number := 1;
	num number := 1;
 
 BEGIN
 
	
	dbms_output.put_line(chr(10) || 'The first ' || n || ' numbers are:');
	
	
	dbms_output.put_line(chr(10) || i);
	
	for i in 1..n-1
	loop
		num := num + 3;
		dbms_output.put_line(num);
	end loop;
 
 END;
 /
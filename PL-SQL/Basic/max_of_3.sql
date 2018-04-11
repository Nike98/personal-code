/*
 * This program takes 3 integer inputs from 
 * the User, evaluates them and displays back
 * the largest among the 3 inputs.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num1 number(10) := &num1;
	num2 number(10) := &num2;
	num3 number(10) := &num3;
 
 BEGIN
 
	dbms_output.put_line(chr(13) || '==========================================');
	if (num1 > num2) and (num1 > num3) then
		dbms_output.put_line(chr(13) || ' ' || num1 || ' is the Largest Number');
	
	elsif (num2 > num1) and (num2 > num3) then
		dbms_output.put_line(chr(13) || ' ' || num2 || ' is the Largest Number');
		
	else
		dbms_output.put_line(chr(13) || ' ' || num3 || ' is the Largest Number');
	end if;
	dbms_output.put_line(chr(13) || '==========================================');
 
 END;
 /
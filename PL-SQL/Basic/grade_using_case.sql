/*
 * Write a PL/SQL program to display the description 
 * against a grade using CASE statement.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	grade char(1) := '&grade';
 
 BEGIN
 
	case grade
	
		when 'a' then
			dbms_output.put_line(chr(10) || 'Your Grade is: Outstanding');
			
		when 'b' then
			dbms_output.put_line(chr(10) || 'Your Grade is: Excellent');
			
		when 'c' then
			dbms_output.put_line(chr(10) || 'Your Grade is: Very Good');
			
		when 'd' then
			dbms_output.put_line(chr(10) || 'Your Grade is: Average');
			
		when 'e' then
			dbms_output.put_line(chr(10) || 'Your Grade is: Poor');
			
		when 'f' then
			dbms_output.put_line(chr(10) || 'Your Grade is: Fail');
			
		else
			dbms_output.put_line(chr(10) || 'WRONG INPUT');
	
	end case;
 
 END;
 /
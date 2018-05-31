
/*
 * b) Write a PL/SQL block to accept a number between 100 and 200,
 * and second number between 1 to 10 and check whether the 
 * first number is divisible by the second.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	first_num number(3,0) := &first_num;					-- Initializing and taking input for the 1st NUMBER
	second_num number(2,0) := &second_num;					-- Initializing and taking input for the 2nd NUMBER
 
 BEGIN
 
	if first_num >= 100 and first_num <=200 then
	
		if second_num >= 1 and second_num <= 10 then
		
			dbms_output.put_line(chr(10) || ' The Division = ' || first_num / second_num);
		
		end if;
		
	else
	
		dbms_output.put_line(chr(10) || ' Faulty Input.');
	
	end if;
 
 END;
 /
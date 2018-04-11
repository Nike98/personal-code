/*
 * This program take input from the 
 * User, checks whether it matches a
 * grade category or not and displays
 * the grade.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	inp number := &inp;		-- Declaring the variable, taking the input from the user and storing the input in the variable
	msg varchar2(20);		-- Declaring a msg variable to store the output to be shown to the User.
 
 BEGIN
 
	if inp >= 90 then
		msg := ' A+ Grade !!';
	
	elsif inp >= 80 then
		msg := ' A Grade !!';
		
	elsif inp >= 70 then
		msg := ' B+ Grade !!';
			
	elsif inp >= 60 then
		msg := ' B Grade !!';
			
	elsif inp >= 50 then
		msg := ' C+ Grade !!';
			
	elsif inp >= 40 then
		msg := ' C Grade !!';
			
	else
		msg := ' Fail :(  !!';
	end if;
	
	dbms_output.put_line(chr(13) || msg);
 
 END;
 /
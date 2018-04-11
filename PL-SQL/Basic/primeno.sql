/*
 * This program takes input from the USER
 * as an integer and checks whether it is
 * a Prime number or Not.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num number:=&num;		-- Declaring the variable as well as scanning it within the same line
	i number;		-- For Looping
	flag boolean;
	
BEGIN

	i:= 2;		-- Initializing the value of input	
	flag := true;		-- Setting the value of flag to be true by default
	
	for i in 2..num/2 loop
		if mod (num, i) = 0 then -- if num % i == 0 is written in C
			flag := false;
			exit;
		end if;
	end loop;
	
	if not flag then
		dbms_output.put_line(chr(13) || ' Not a Prime Number');
	
	else
		dbms_output.put_line(chr(13) || ' Prime Number');
	end if;
	
END;
/
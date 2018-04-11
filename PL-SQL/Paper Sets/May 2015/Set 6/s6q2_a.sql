
/*
 * a) Write a PL/SQL block to accept two Strings and check whether they are Equal or Not.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	str1 varchar2(20) := '&str1';			-- Declaring the Variable to store the 1st String and Taking the input also
	str2 varchar2(20) := '&str2';			-- Declaring the Variable to store the 2nd String and Taking the input also
 
 BEGIN
 
	dbms_output.put_line(chr(10) || '##########################################' || chr(10));
	
	if str1 = str2 then
	
		dbms_output.put_line(chr(9) || ' Both are Equal');		-- Printed on the Console if both the Strings are EQUAL
		
	else
	
		dbms_output.put_line(chr(9) || ' Both are Not Equal');	-- Printed on the Console if both the Strings are Not EQUAL
	
	end if;
	
	dbms_output.put_line(chr(10) || '##########################################');
 
 END;
 /
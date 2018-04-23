
/*
 * This program takes input from the User as a String
 * and Counts the Vowels in that String
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	str varchar2(50) := '&str';
	vow_count varchar2(10) := '';			-- To store the count of the vowels
	c char;								-- To check the vowels in the string
 
 BEGIN
 
	FOR i IN 1..length(str)
	LOOP
	
		c := substr(str, i, 1);
		
		if c in ('a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U') then
		
			vow_count := c;
		
		end if;
	
	END LOOP;
	
	dbms_output.put_line(chr(10) || '############################################################' || chr(10));
	dbms_output.put_line(chr(9) || 'The Vowel Count = ' || vow_count);
	dbms_output.put_line(chr(10) || '############################################################');
 
 END;
 /
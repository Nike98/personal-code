
/*
 * c) Write a PL/SQL block to accept a String from
 * the User and count the Vowels in it.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	str varchar2(50) := '&str';
	vow_count number(10) := 0;			-- To store the count of the vowels
	c char;								-- To check the vowels in the string
 
 BEGIN
 
	FOR i IN 1..length(str)
	LOOP
	
		c := substr(str, i, 1);
		
		if c in ('a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U') then			-- Detecting the Vowels
		
			vow_count := vow_count + 1;			-- Incrementing the count vowels
		
		end if;
	
	END LOOP;
	
	dbms_output.put_line(chr(10) || '############################################################' || chr(10));
	dbms_output.put_line(chr(9) || 'The Vowel Count = ' || vow_count);
	dbms_output.put_line(chr(10) || '############################################################');
 
 END;
 /
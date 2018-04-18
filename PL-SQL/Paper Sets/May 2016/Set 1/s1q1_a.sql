
/*
 * a) Write a PL/SQL block to print the Number EVEN or ODD till 20
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 BEGIN
 
			-- Prints all the EVEN Numbers
			
	dbms_output.put_line(chr(10) || '##########################################' || chr(10));
	dbms_output.put_line(chr(9) || 'EVEN Numbers are : ' || chr(10));
	
	for i in 1..20
	loop
	
		if mod(i, 2) = 0 then
		
			dbms_output.put_line(chr(9)|| i);
		
		end if;
	
	end loop;
	
	dbms_output.put_line(chr(10) || '##########################################' || chr(10));
	
			-- Prints all the ODD Numbers
	
	dbms_output.put_line(chr(10) || '##########################################' || chr(10));
	dbms_output.put_line(chr(9) || 'ODD Numbers are : ' || chr(10));
	
	for i in 1..20
	loop
	
		if mod(i, 2) <> 0 then
		
			dbms_output.put_line(chr(9)|| i);
		
		end if;
	
	end loop;
	
	dbms_output.put_line(chr(10) || '##########################################' || chr(10));
 
 END;
 /
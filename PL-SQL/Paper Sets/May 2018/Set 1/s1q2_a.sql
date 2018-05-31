
/*
 * Write a PL/SQL block that Displays all the Even Numbers from 1 to 200.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;

 BEGIN

	dbms_output.put_line(chr(10) || ' The Even Numbers are : ');
	
	for i in 1..200
	loop
	
		if mod(i,2) = 0 then
		
			dbms_output.put_line(chr(10) || ' ' || i);
		
		end if;
	
	end loop;
 
 END;
 /

/*
 * Write a PL/SQL block which prints first 3 Even Numbers.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	foo number(1);
 
 BEGIN
 
	foo := 0;			-- Initializing foo variable to be 0 before getting incremented
	
	dbms_output.put_line(chr(10) || ' The Even Numbers are : ');
	
	for i in 1..20
	loop
	
		if foo < 3 then					-- Condition for foo to be less than or equal to 3
		
			if mod(i, 2) = 0 then			-- Even number logic
			
				dbms_output.put_line(chr(10) || ' ' || i);
				
				foo := foo + 1;				-- Incrementing foo
				
			end if;
			
		else 
		
			exit;							-- Exit if foo is greater than 3
		
		end if;
		
	end loop;
 
 END;
 /
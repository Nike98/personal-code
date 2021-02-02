
/*
 * Write a PL/SQL function to display even numbers till a particular accepted number.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE OR REPLACE FUNCTION even(num NUMBER) RETURN NUMBER
 IS
 
	i number;

 BEGIN
 
	i := 1;
	
	dbms_output.new_line();
	
	WHILE i <= num
	LOOP
	
		IF MOD(i, 2) = 0
		THEN
		
			dbms_output.put_line(' ' || i);
		
		END IF;
		
		i := i + 1;
	
	END LOOP;
	
	return NULL;
 
 END;
 /
 
 DECLARE
 
	num number := &num;
 
 BEGIN
 
	dbms_output.put_line(chr(10) || ' Even numbers till ' || num || ' are: ');
	dbms_output.put_line(even(num));
 
 END;
 /
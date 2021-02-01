/*
 * Write a PL/SQL function to generate Fibonacci series.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE OR REPLACE FUNCTION fibonacci(num NUMBER) RETURN INTEGER
 AS	
 BEGIN
 
	IF num = 0 or num = 1
	THEN 
	
		return num;
		
	ELSE
	
		return fibonacci(num - 1) + fibonacci(num - 2);
		
	END IF;
	
 END;
 /
 
 DECLARE
 
	num number := &iterations;
 
 BEGIN
 
	FOR i IN 0..num - 1
	LOOP

		dbms_output.put_line(fibonacci(i));
		
	END LOOP;
 
 END;
 /
 
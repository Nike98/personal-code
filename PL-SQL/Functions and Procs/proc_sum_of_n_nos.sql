
/*
 * Write a procedure to calculate sum of first N numbers.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE OR REPLACE PROCEDURE sum_of_n_nos(num IN NUMBER, sums OUT NUMBER)
 AS

	n number;
 
 BEGIN
 
	sums := 0;
	n := num;
	
	WHILE (n > 0)
	LOOP
	
		sums := sums + n;
		n := n - 1;
		
		EXIT WHEN n = 0;
	
	END LOOP;
 
 END;
 /
 
 DECLARE
 
	n number := &num;
	res number;
 
 BEGIN
 
	sum_of_n_nos(n, res);
	dbms_output.put_line(chr(10) || ' The Sum is: ' || res);
 
 END;
 /
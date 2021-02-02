
/*
 * Write a PL/SQL procedure to print 5 odd numbers starting from 
 * 13 and display the sum of all using “For loop”.
 */
 
 CREATE OR REPLACE PROCEDURE odd_sum(start_num IN NUMBER, iter IN number, sums OUT NUMBER)
 AS
 
	s_num number;
	max_iter number;
	count_iter number;
	
 BEGIN
 
	s_num := start_num;			-- assigning the value of the starting number to s_num
	sums := 0;					
	max_iter := 100;			-- defining the max iterations to be up till 100 only for the loop
	count_iter := 1;
	
	FOR i IN s_num..max_iter
	LOOP
	
		IF MOD(i, 2) != 0 		-- checking for odd numbers
		THEN
			
			dbms_output.put_line(chr(10) || ' ' || i);
			sums := sums + i;
			
			count_iter := count_iter + 1;
			
			EXIT WHEN count_iter = iter + 1;		-- exiting the loop after the numbers of iterations specified by the user
		
		END IF;
	
	END LOOP;
 
 END;
 /
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	start_num number := &start_num;
	iter number := &iterations;
	sums number;
 
 BEGIN
 
	odd_sum(start_num, iter, sums);
	
	dbms_output.put_line(chr(10) || ' The Sum of all the above Odd Numbers is: ' || sums);
 
 END;
 /
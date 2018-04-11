
 /*
  * a) Write a PL/SQL block to accept 2 numbers and print the smallest from them
  */
  
  
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	num1 number := &num1;			-- Initializing variable num1 and taking the input at the same time
	num2 number := &num2;			-- Initializing variable num1 and taking the input at the same time
 
 BEGIN
 
	if num1 != num2 then
	
		if num1 < num2 then
		
			dbms_output.put_line(chr(10) || '########################################' || chr(10));
			dbms_output.put_line(chr(9) || ' ' || num1 || ' is the Smallest');		-- Prints the answer
			dbms_output.put_line(chr(10) || '########################################');
			
		else
		
			dbms_output.put_line(chr(10) || '####################################################' || chr(10));
			dbms_output.put_line(chr(9) || ' ' || num2 || ' is the Smallest');		-- Prints the answer
			dbms_output.put_line(chr(10) || '####################################################');
		end if;
		
	else
	
		dbms_output.put_line(chr(10) || '####################################################' || chr(10));
		dbms_output.put_line(chr(9) ||' Both the values are Equal');
		dbms_output.put_line(chr(10) || '####################################################');
	
	end if;
 
 END;
 /
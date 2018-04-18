
/*
 * b) Using Cursor print the information of Customer having product name as 'Radio'.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	CURSOR cur_cust					-- Declaring the Cursor to be Used
	IS
		-- Select query to be executed
		select cust_id, cust_name, cust_place, cust_mobile_no, date_of_purchase from customer
		where prod_id in (select prod_id from product where prod_name = 'RADIO');
		
	id customer.cust_id%TYPE;				-- Local Variable to store the ID of the Customer
	name customer.cust_name%TYPE;			-- Local Variable to store the Name of the Customer
	place customer.cust_place%TYPE;			-- Local Variable to store the Place of Living of the Customer
	mobile customer.cust_mobile_no%TYPE;	-- Local Variable to store the Mobile Number of the Customer
	dop customer.date_of_purchase%TYPE;		-- Local Variable to store the Date of Purchase of the Customer
 
 BEGIN
 
	OPEN cur_cust;			-- Opening the Cursor
	
	if cur_cust%ISOPEN then		-- If the Cursor ISOPEN then execute the further statements
	
		dbms_output.put_line(chr(10) || '#########################################################' || chr(10));
	
		loop
		
				-- Fetches all the records acquired by the Cursor in the Local Variables
			FETCH cur_cust into id, name, place, mobile, dop;			
			
			EXIT when cur_cust%NOTFOUND;			-- Exits if the no values are found by the Cursor
			
			if cur_cust%FOUND then
				
				dbms_output.put_line(chr(9) || ' Customer ID : ' || id);
				dbms_output.put_line(chr(9) || ' Customer Name : ' || name);
				dbms_output.put_line(chr(9) || ' Customer Place : ' || place);
				dbms_output.put_line(chr(9) || ' Customer Mobile Number : ' || mobile);
				dbms_output.put_line(chr(9) || ' Date of Purchase : ' || dop);
				dbms_output.put_line(chr(9));
			
			end if;
		
		end loop;
		
		dbms_output.put_line(chr(10) || '#########################################################');
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
	
	end if;
	
	CLOSE cur_cust;				-- CLOSE the CURSOR
 
 END;
 /
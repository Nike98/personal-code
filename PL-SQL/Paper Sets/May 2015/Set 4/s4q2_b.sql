
/*
 * b) Write a PL/SQL block to accept emp_id and print city and name of the Employee
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp						-- Declaring the Cursor to be used
	IS
		select emp_id, emp_name, emp_city
		from employee;					-- The select statement to be executed
		
	id employee.emp_id%TYPE;			-- Variable to store the ID of the Employee
	name employee.emp_name%TYPE;		-- Variable to store the Name of the Employee
	city employee.emp_city%TYPE;		-- Variable to store the City of the Employee
	
	inp_id number := &inp_id;			-- Declaring and taking the input from the User for the particular ID to be fetched
 
 BEGIN
 
	OPEN cur_emp;						-- Opens the CURSOR
	
	if cur_emp%ISOPEN then
	
		dbms_output.put_line(chr(10) || '#########################################################' || chr(10));
		
		loop
		
			FETCH cur_emp into id, name, city;			-- Fetches the data into the Local Variables
			
			EXIT when cur_emp%NOTFOUND;					-- If nothing is found in the table so exit the Cursor
			
			if cur_emp%FOUND then
			
				if inp_id = id then			-- If the Input by the User exists within the table
				
				dbms_output.put_line(chr(9) || ' Employee ID : ' || id);
				dbms_output.put_line(chr(9) || ' Employee Name : ' || name);
				dbms_output.put_line(chr(9) || ' Employee city : ' || city);
			
				end if;
				
			else
			
				dbms_output.put_line(chr(9) || ' Not Entries Found.');
			
			end if;
		
		end loop;
		
		dbms_output.put_line(chr(10) || '#########################################################');
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
	
	end if;
	
	CLOSE cur_emp;				-- Closes the Cursor
 
 END;
 /
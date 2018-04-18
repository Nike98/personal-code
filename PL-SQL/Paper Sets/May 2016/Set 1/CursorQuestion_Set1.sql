
/*
 * Write a PL/SQL block to update the Employee by 20% for
 * Even Records and 10% for Odd Records.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	CURSOR cur_emp				-- Declaring the Cursor to be used
	IS
		select emp_id, emp_salary
		from employee					-- Select statement to e executed
		for update of emp_salary;
		
	id employee.emp_id%TYPE;			-- Variable to store the ID of the Employee
	salary employee.emp_salary%TYPE;	-- Variable to store the Salary of the Employee
 
 BEGIN
 
	OPEN cur_emp;						-- Opens the Cursor
	
	if cur_emp%ISOPEN then				-- If the Cursor ISOPEN then execute the further statements
	
		loop
		
			FETCH cur_emp into id, salary;		-- Fetches the Data into the Local Variables
			
			EXIT when cur_emp%NOTFOUND;			-- Exits the Cursor if not data is found
			
			if cur_emp%FOUND then
			
				if mod(id, 2) = 0 then			-- If the ID is Even 
				
					update employee
					set emp_salary = emp_salary + (emp_salary * 20/100)			-- Update Statement
					where current of cur_emp;
				
				end if;
				
				if mod(id, 2) <> 0 then			-- If the ID is Odd 
				
					update employee
					set emp_salary = emp_salary + (emp_salary * 10/100)			-- Update Statement
					where current of cur_emp;
				
				end if;
			
			end if;
		
		end loop;
	
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
	
	end if;
	
	CLOSE cur_emp;				-- Closes the Cursor
	
	COMMIT;						-- Commits the changes
	
 END;
 /
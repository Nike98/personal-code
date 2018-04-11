

/*
 * c) Using a Cursor update the salary of employee by Rs.1000 whose salary is less then 10000.
 */
 
 DECLARE
 
			-- Declaring the Cursor name and the select statement which stores the pointer in the Cursor
	CURSOR cur_emp 
	IS 
		select emp_salary 
		from employee
		where emp_salary < 10000
		for update of emp_salary;
		
	rec_emp employee.emp_salary%TYPE;			-- Stores the TYPE of column in the rec_emp
 
 BEGIN 
	
	OPEN cur_emp;			-- Opening the Cursor
	
	if cur_emp%ISOPEN then		-- If the Cursor ISOPEN then execute the further statements
	
		loop
		
			fetch cur_emp into rec_emp;			-- Fetching all the records acquired by the Cursor in rec_emp
			
			exit when cur_emp%NOTFOUND;			-- Exits if the Cursor or values are not found
			
			update employee
				set emp_salary = emp_salary + 1000			-- Update Statement
			where current of cur_emp;
		
		end loop;
		
		commit;		-- Commit all the actions performed
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
	
	end if;
	
	CLOSE cur_emp;				-- CLOSE the CURSOR
 
 END;
 /
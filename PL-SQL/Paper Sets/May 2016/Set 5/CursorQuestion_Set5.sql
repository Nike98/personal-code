
/*
 * b) Write a PL/SQL block using Cursor to print information 
 * of the Employee having Salary more than 5000.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	CURSOR cur_emp				-- Declaring the Cursor to be used
	IS
		select emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, emp_dept_no
		from employee;					-- Select statement to be used
		
	id employee.emp_id%TYPE;						-- Local Variable to store the ID of the Employee
	name employee.emp_name%TYPE;					-- Local Variable to store the Name of the Employee
	city employee.emp_city%TYPE;					-- Local Variable to store the City of the Employee
	job employee.emp_job%TYPE;						-- Local Variable to store the Job of the Employee
	salary employee.emp_salary%TYPE;				-- Local Variable to store the Salary of the Employee
	join_date employee.emp_join_date%TYPE;			-- Local Variable to store the Joining Date of the Employee
	commission employee.emp_commission%TYPE;		-- Local Variable to store the Commission of the Employee
	dept_no employee.emp_dept_no%TYPE;				-- Local Variable to store the Department Number of the Employee
 
 BEGIN
 
	OPEN cur_emp;			-- Opening the Cursor
	
	if cur_emp%ISOPEN then		-- If the Cursor ISOPEN then execute the further statements
	
		dbms_output.put_line(chr(10) || '#########################################################' || chr(10));
	
		loop
		
				-- Fetches all the records acquired by the Cursor in the Local Variables
			FETCH cur_emp into id, name, city, job, salary, join_date, commission, dept_no;			
			
			EXIT when cur_emp%NOTFOUND;			-- Exits if the no values are found by the Cursor
			
			if cur_emp%FOUND then
			
				if salary > 5000 then
				
					dbms_output.put_line(chr(9) || ' Employee ID : ' || id);
					dbms_output.put_line(chr(9) || ' Employee Name : ' || name);
					dbms_output.put_line(chr(9) || ' Employee City : ' || city);
					dbms_output.put_line(chr(9) || ' Employee Job : ' || job);
					dbms_output.put_line(chr(9) || ' Employee Salary : ' || salary);
					dbms_output.put_line(chr(9) || ' Employee Joining Date : ' || join_date);
					dbms_output.put_line(chr(9) || ' Employee Commission : ' || commission);
					dbms_output.put_line(chr(9) || ' Employee Department Number : ' || dept_no);
					dbms_output.put_line(chr(9));
				
				end if;
			
			end if;
		
		end loop;
		
		dbms_output.put_line(chr(10) || '#########################################################');
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
	
	end if;
	
	CLOSE cur_emp;				-- CLOSE the CURSOR
 
 END;
 /
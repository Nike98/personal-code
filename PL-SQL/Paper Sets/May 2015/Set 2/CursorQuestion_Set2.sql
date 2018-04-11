
/*
 * c) Using a Cursor display the name, salary of the Employee working in Department no. 20.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp							-- Declaring the CURSOR	
	IS
		select emp_name, emp_salary, emp_dept_no		-- The SELECT statement to retrieve the data
		from employee
		where emp_dept_no = 20;
		
	name employee.emp_name%TYPE;			-- Variable to store the Name of the Employee
	salary employee.emp_salary%TYPE;		-- Variable to store the Salary of the Employee
	department employee.emp_dept_no%TYPE;	-- Variable to store the Department number
 
 BEGIN
 
	OPEN cur_emp;							-- OPEN the CURSOR
	
	if cur_emp%ISOPEN then		-- If the Cursor ISOPEN then execute the further statements
	
		FETCH cur_emp into name, salary, department;				-- FETCH the data into the Local variables
	
		if cur_emp%FOUND then
	
			dbms_output.put_line(chr(10) || '####################################################' || chr(10));
			dbms_output.put_line(chr(9) || ' Employee Name : ' || name);
			dbms_output.put_line(chr(9) || ' Employee Salary : ' || salary);
			dbms_output.put_line(chr(9) || ' Employee Department Number : ' || department);
			dbms_output.put_line(chr(10) || '####################################################');
			
		else
		
			dbms_output.put_line(chr(10) || '#########################################################' || chr(10));
			dbms_output.put_line(chr(13) || ' Either no values found in the Row or no Row Exists');
			dbms_output.put_line(chr(10) || '#########################################################');
		
		end if;
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
		
	end if;
	
	CLOSE cur_emp;				-- CLOSE the CURSOR
 
 END;
 /
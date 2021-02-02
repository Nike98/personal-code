
/*
 * Write a PL/SQL code to retrieve the employee name, join_date, 
 * and designation from employee database of an employee whose 
 * number is input by the user.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	eno employees.empno%TYPE := &employee_no;		-- getting the input of the employee number from the user to find the employee details
	name employees.ename%TYPE;
	hdate employees.hire_date%TYPE;
	job employees.job%TYPE;
	
 BEGIN
 
	-- Query to find the employee details and assign them, to the local variables
	SELECT ename, hire_date, job
	INTO name, hdate, job
	FROM employees
	WHERE empno = eno;

	dbms_output.put_line(chr(10) || 'Name: ' || name);
	dbms_output.put_line('Hire Date: ' || hdate);
	dbms_output.put_line('Designation: ' || job);
	
 END;
 /

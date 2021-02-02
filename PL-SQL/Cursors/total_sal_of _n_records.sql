
/*
 * Write a PL/SQL code to calculate the total salary of first n 
 * records of emp table. The value of n is passed to cursor as parameter.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp(n number)
	IS
		SELECT empno, net_salary 
		FROM empsal;
 
	num_of_records number;
	eno empsal.empno%TYPE;
	total_salary empsal.net_salary%TYPE;
 
 BEGIN
 
	num_of_records := &num_of_records;
	
	-- passing the value we got from the user as a parameter to the CURSOR
	OPEN cur_emp(num_of_records);
	
	dbms_output.put_line(chr(10) || ' Emp_No' || chr(9) || 'Total_Salary');
	
	-- simple loop to print a dividing '-' between the heading and the data
	FOR i IN 1..30 LOOP
	
		dbms_output.put('-');
		
	END LOOP;
	
	LOOP
	
		FETCH cur_emp INTO eno, total_salary;
		
		EXIT WHEN cur_emp%ROWCOUNT = num_of_records + 1 OR cur_emp%NOTFOUND;
		
		dbms_output.put_line(chr(10) || ' ' || eno || chr(9) || total_salary);
	
	END LOOP;
 
 END;
 /
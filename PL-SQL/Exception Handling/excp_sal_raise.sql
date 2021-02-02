 
 /*
  * Write a PL/SQL code to raise an exception to display the message 
  * “ This employee is not entitled to get the raise in salary”. 
  * (The employee is eligible to get the raise if his/her designation is ‘CLERK’ or ’SALESMAN’).
  */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;

 DECLARE
 
	e_job employees.job%TYPE;
	empn number := &emp_no;
	e_job_sal EXCEPTION;
 
 BEGIN
 
	SELECT JOB INTO e_job
	FROM employees
	WHERE empno = empn;
	
	IF e_job = 'CLERK' OR e_job = 'SALESMAN' THEN
	
		dbms_output.put_line('Employee is Eligible');
		
	ELSE
	
		RAISE e_job_sal;
	
	END IF;
	
	EXCEPTION
	
		WHEN e_job_sal THEN
		
			dbms_output.put_line('Not Eligible');
 
 END;
 /
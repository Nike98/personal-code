 
 /*
  * Write a PL/SQL code to bind an error code “-00054” 
  * with an exception name “Resource_Busy”.
  */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;

 DECLARE
 
	res_wait EXCEPTION;
	PRAGMA EXCEPTION_INIT(res_wait, -00054);
	enum employees.empno%TYPE;
	e_sal employees.sal%TYPE;
	e_job employees.job%TYPE;
 
 BEGIN
 
	enum := &emp_no;
	
	SELECT JOB INTO e_job
	FROM employees
	WHERE empno = enum
	FOR UPDATE WAIT 30;
	
	IF e_job = 'SALESMAN' THEN
	
		UPDATE employees 
		SET sal = e_sal + e_sal * 0.10
		WHERE empno = enum;
	
	END IF;
	
	EXCEPTION
		
		WHEN res_wait THEN
			
			dbms_output.put_line('Resource Busy');
 
 END;
 /
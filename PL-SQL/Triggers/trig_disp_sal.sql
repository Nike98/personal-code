 
 /*
  * Write a PL/SQL code to accept a empno and display its salary. 
  * Display error if the empno does not exists.
  */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;

 DECLARE
 
	excep EXCEPTION;
	num employees.empno%TYPE := &emp_no;
	name employees.ename%TYPE;
	sal employees.sal%TYPE;
	
	CURSOR cur (n employees.empno%TYPE)
	IS
		SELECT ENAME, SAL
		FROM EMPLOYEES
		WHERE EMPNO = n;
 
 BEGIN
 
	OPEN cur(num);
	
	IF cur%ISOPEN THEN
	
		FETCH cur INTO name, sal;
		
		IF cur%NOTFOUND THEN
		
			RAISE excep;
			
		ELSE
		
			dbms_output.put_line(chr(10) || 'NAME: ' || name || chr(9) || 'SALARY: ' || sal);
		
		END IF;
	
	END IF;
	
	EXCEPTION
	WHEN excep THEN
	
		dbms_output.put_line(chr(10) || 'Employee does not exist.');
		
	CLOSE cur;
 
 END;
 /
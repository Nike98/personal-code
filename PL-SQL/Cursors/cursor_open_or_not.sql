
/*
 * Write an explicit cursor which retrieves the data from emp table 
 * and check whether cursor is open or not. If not then open it else 
 * print message that “Cursor already open”.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp
	IS
		SELECT empno, ename, sal
		FROM employees
		ORDER BY sal DESC;
		
	eno employees.empno%TYPE;
	name employees.ename%TYPE;
	sal employees.sal%TYPE;
 
 BEGIN

	OPEN cur_emp;
 
	IF cur_emp%ISOPEN = FALSE THEN
	
		dbms_output.put_line(chr(10) || ' Cursor is not open.');
		
	ELSE
	
		dbms_output.put_line(chr(10) || 'Cursor is already open.' || chr(10));
		
		dbms_output.put_line(chr(10) || ' Emp_No' || chr(9) || 'Name' || chr(9) || 'Salary');

		-- simple loop to print a dividing '-' between the heading and the data
		FOR i IN 1..40 LOOP
	
			dbms_output.put('-');
		
		END LOOP;
		
		LOOP
		
			FETCH cur_emp INTO eno, name, sal;
			
			EXIT WHEN cur_emp%ROWCOUNT = 5 OR cur_emp%NOTFOUND;
			
			
			dbms_output.put_line(chr(10) || ' ' || eno || chr(9) || name || chr(9) || sal);
		
		END LOOP;
		
		CLOSE cur_emp;
	
	END IF;
 
 END;
 /
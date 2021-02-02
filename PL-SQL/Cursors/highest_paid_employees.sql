
/*
 * Write a PL/SQL code to display employee number, 
 * name and basic of 5 highest paid employees.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp
	IS
		SELECT EMPNO, ENAME, SAL
		FROM EMPLOYEES
		ORDER BY SAL DESC;
		
	eno employees.empno%TYPE;
	name employees.ename%TYPE;
	sal employees.sal%TYPE;
	
	i int;
 
 BEGIN
 
	i := 1;
	
	OPEN cur_emp;
	
	dbms_output.put_line(chr(10) || ' EMPNO' || chr(9) || 'NAME' || chr(9) || 'BASIC SALARY');	
	
	-- simple loop to print a dividing '-' between the heading and the data
	FOR i IN 1..40 LOOP
	
		dbms_output.put('-');
		
	END LOOP;
	
	LOOP
	
		FETCH cur_emp INTO eno, name, sal;
		
		EXIT WHEN cur_emp%ROWCOUNT = 5 OR cur_emp%NOTFOUND;
		
		dbms_output.put_line(chr(10) || ' ' || eno || chr(9) || name || CHR(9) || sal);
	
	END LOOP;
	
	CLOSE cur_emp;
 
 END;
 /
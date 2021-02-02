
/*
 * Write a PL/SQL function that accepts department number and 
 * returns the total salary of that department. Write the code 
 * to call your function.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE OR REPLACE FUNCTION dept_total_sal (dept_num NUMBER) return number
 IS
 
	total_salary employees.sal%TYPE;
	 
 BEGIN
 
	SELECT SUM(SAL) INTO total_salary
	FROM EMPLOYEES
	WHERE DEPT_NO = dept_num;
	
	return total_salary;
	
 END;
 /
 
 DECLARE
 
	dept number := &dept_no;
	total number;
 
 BEGIN
 
	total := dept_total_sal(dept);
	
	dbms_output.put_line(chr(10) || ' Department No: ' || dept || chr(9) || ' Total Salary: ' || total);
 
 END;
 /
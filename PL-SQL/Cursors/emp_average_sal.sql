
/*
 * Write a PL/SQL code to update the salary of employees 
 * who earn less than the average salary.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp
	IS
		SELECT * FROM employees;
		
	avg_sal employees.sal%TYPE;
 
 BEGIN
 
	SELECT ROUND(AVG(SAL)) INTO avg_sal FROM employees;
	
	FOR i IN cur_emp LOOP
	
		IF (i.sal < avg_sal) THEN
			UPDATE employees
			SET SAL = SAL + SAL * 0.05
			WHERE EMPNO = i.EMPNO;
		END IF;
		
	END LOOP;
	
 END;
 /
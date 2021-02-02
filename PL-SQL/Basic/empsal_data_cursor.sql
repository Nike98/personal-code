
/*
 * 
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR UPDATE_SAL
	IS
		select empno, sal 
		from employees
		for update;
		
	emp_no employees.empno%TYPE;
	emp_sal employees.sal%TYPE;
	
	sal_empno empsal.net_sal%TYPE;
 
 BEGIN
 
	OPEN UPDATE_SAL
	
	if UPDATE_SAL%ISOPEN then
		loop
			FETCH UPDATE_SAL into emp_no, emp_sal;
			EXIT when UPDATE_SAL%NOTFOUD;
			
			if UPDATE_SAL%FOUND then
				update empsal
					set net_salary = emp_sal,
					set da = 
 
 END;
 /

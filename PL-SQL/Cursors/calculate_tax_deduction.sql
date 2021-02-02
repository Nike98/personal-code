
/*
 * Write a PL/SQL code to calculate tax for an employee of an organization 
 * –XYZ and to display his/her name & tax, by creating a table under 
 * employee database as below.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_emp
	IS
		select empno, gross_salary
		from empsal;
		
	eno empsal.empno%TYPE;
	tax number(10,2);
 
 BEGIN
 
	OPEN cur_emp;
	
	if cur_emp%ISOPEN then
	
		loop
		
			FETCH cur_emp into eno, tax;
			
			EXIT when cur_emp%NOTFOUND;
			
			tax := tax * 0.18;
			
			dbms_output.put_line(chr(10) || 'Employee No: ' || eno || chr(9) || 'Tax: ' || tax);
		
		end loop;
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
		
	end if;
	
	CLOSE cur_emp;
	
 END;
 /

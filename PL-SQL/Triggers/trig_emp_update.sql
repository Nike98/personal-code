
/*
 * Write a trigger that fires for update on employee 
 * table and stores updated records in a new table.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE TRIGGER EMP_UPDATE_STORE
 AFTER UPDATE
 ON EMPLOYEES
 FOR EACH ROW
 
 DECLARE
 
	opertn varchar2(10);
 
 BEGIN
 
	IF UPDATING THEN
		
		opertn := 'UPDATE';
		INSERT INTO TRIG_EMPLOYEES_DATA VALUES (:OLD.EMPNO, :OLD.ENAME, :OLD.JOB, :OLD.MGR, :OLD.HIRE_DATE, :OLD.SAL, :OLD.COMM, opertn, sysdate);
	
	END IF;
 
 END;
 /
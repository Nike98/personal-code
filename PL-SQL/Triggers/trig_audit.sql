

/*
 * Create an after statement level trigger on employee table, whenever an update ,
 * insert and delete operation occurs on employee table, a row is added to the
 * emp_audit table recording the date, user and action.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE OR REPLACE TRIGGER TRIG_AUDIT
 AFTER INSERT OR UPDATE OR DELETE 
 ON EMPLOYEES
 
 DECLARE
 
	opertn varchar2(10);
 
 BEGIN
 
	IF UPDATING THEN
	
		opertn := 'UPDATE';
		
	ELSIF INSERTING THEN
	
		opertn := 'INSERT';
		
	ELSIF DELETING THEN
	
		opertn := 'DELETE';
		
	END IF;
	
	INSERT INTO EMP_AUDIT (ACTION) VALUES (opertn);
 
 END;
 /
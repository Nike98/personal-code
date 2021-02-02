
/*
 * Write a trigger to display the message “Invalid name” when name of an employee
 * starts with a digit while record is inserted.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 CREATE TRIGGER INVALID_UNAME
 BEFORE INSERT
 ON EMPLOYEES
 FOR EACH ROW 
 
 BEGIN
 
	IF (REGEXP_LIKE(:NEW.ENAME, '^[0-9]')) 
	THEN
	
		RAISE_APPLICATION_ERROR(-020100, 'Invalid name entry type');
		
	END IF;
 
 END;
 /
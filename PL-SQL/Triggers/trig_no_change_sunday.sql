 
 /*
  * Write a trigger not to allow making changes in a table on Sunday.
  */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;

 CREATE OR REPLACE TRIGGER TRIG_NO_CHANGE_SUNDAY
 BEFORE INSERT OR DELETE OR UPDATE ON employees
 FOR EACH ROW
 
 BEGIN
	
	IF (UPPER(TO_CHAR(SYSDATE, 'DAY')) = 'SUN') THEN
	
		RAISE_APPLICATION_ERROR(-20001, 'Cannot make changes to the databse on SUNDAY');
	
	END IF;
 
 END;
 /
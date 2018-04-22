
/*
 * This Procedure creates a Trigger to store the old Employee
 * information when an Update Event is fired on the Employee Table.
 */
 
 CREATE TRIGGER Employee_update_Trig
 AFTER UPDATE OR DELETE ON Employee
 FOR EACH ROW
 
 DECLARE
 
	oper varchar2(8);
	loc_id number(6,0);
	loc_name varchar2(20);
	loc_city varchar2(20);			-- All the Local Variables to store the data from the Employee table
	loc_job varchar2(20);
	loc_salary number(10,0);
	loc_commission number(8,0);
 
 BEGIN
 
	IF updating THEN
		oper := 'update';
	END IF;
	
	IF deleting THEN
		oper := 'delete';
	END IF;
	
	/*
	 * Storing all the old (data before the updation or deletion)
	 * in the Local Variables
	 */
	 
	loc_id := :old.emp_id;
	loc_name := :old.emp_name;
	loc_city := :old.emp_city;
	loc_job := :old.emp_job;
	loc_salary := :old.emp_salary;
	loc_commission := :old.emp_commission;
	
	-- Inserting all the acquired values in the local variables into the New 'OLD_EMPLOYEE_DATA' table.
	
	insert into old_employee_data (id, name, city, job, salary, commission, modify_date)
	values (loc_id, loc_name, loc_city, loc_job, loc_salary, loc_commission, sysdate);
 
 END;
 /
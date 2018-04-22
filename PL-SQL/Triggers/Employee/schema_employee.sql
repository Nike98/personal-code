
 -- Create Table to store the Data
 
 create table old_employee_data
 (
	id number(6,0),
	name varchar2(20),
	city varchar2(20),
	job varchar2(20),
	salary number(10,0),
	commission number(8,0),
	modify_date date
 );
 
 
 -- Commit 
 
 commit;
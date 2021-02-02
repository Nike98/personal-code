
 -- Creating table TRIG_EMPLOYEES_DATA
 create table trig_employees_data
 (
	empno int,
 	ename varchar2(20) not null,
 	job varchar2(20) not null,
 	mgr int,
 	hire_date date,
 	sal decimal(10,2),
 	comm decimal(10,2),
	opertn varchar2(10),
	modified_at date
 );
 
 create table emp_audit
 (
	action_date date default sysdate,
	user_name varchar2(30) default user not null,
	action varchar2(10) not null
 );
 
 COMMIT;
 
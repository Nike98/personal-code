 
 -- Create Table Dept
 
 create table dept
 (
	dept_no number(2,0) constraints dpt_no_pk primary key,
	dname varchar2(15) not null,
	location varchar2(10) not null
 );
 
 
 -- Create Table Employee
 
 create table employee
 (
	emp_id number(4,0) constraints emp_id_pk primary key,
	emp_name varchar2(10) not null,
	emp_city varchar2(15) not null,
	emp_job varchar2(15) not null,
	emp_salary number(6,0) not null,
	emp_join_date date not null,
	emp_commission number(3,0) default '10',
	email_id varchar2(20) not null unique,
	emp_dept_no number(2,0) constraints emp_dept_no_fk references dept(dept_no)
 );
 
 
 -- Inserting Data into Table Dept
 
 insert into dept (dept_no, dname, location) values (10, 'ACCOUNTING', 'MUMBAI');
 insert into dept (dept_no, dname, location) values (20, 'RESEARCH', 'BANGALORE');
 insert into dept (dept_no, dname, location) values (30, 'SALES', 'DELHI');
 insert into dept (dept_no, dname, location) values (40, 'OPERATIONS', 'CHENNAI');
 
 
 -- Inserting Data into Table Employee
 
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7369, 'SMITH', 'DELHI', 'CLERK', 28000, '13-JUN-1993', '', 'smith@gmail.com', 20);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7499, 'ALLEN', 'MUMBAI', 'SALESMAN', 36000, '15-AUG-1998', '', 'allen@aol.com', 30);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7521, 'WARD', 'CHENNAI', 'SALESMAN', 32500, '26-MAR-1996', 500, 'ward@hotmail.com', 30);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7566, 'JONES', 'DELHI', 'MANAGER', 49750, '31-OCT-1995', 150, 'jones@yahoo.com', 20);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7698, 'BLAKE', 'BANGALORE', 'MANAGER', 48500, '11-JUN-1992', 180, 'blake@gmail.com', 30);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7782, 'CLARK', 'MUMBAI', 'MANAGER', 44500, '14-MAY-1993', 200, 'clark@aol.com', 10);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7788, 'SCOTT', 'BANGALORE', 'ANALYST', 50000, '05-MAR-1996', 220, 'scott@yahoo.com', 20);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7839, 'KING', 'CHENNAI', 'PRESIDENT', 70000, '09-JUN-1990', '', 'king@hotmail.com', 10);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7844, 'TURNER', 'MUMBAI', 'SALESMAN', 45000, '13-JUN-1993', '', 'turner@gmail.com', 30);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7876, 'ADAMS', 'BANGALORE', 'CLERK', 31000, '10-JUN-1999', 500, 'adams@yahoo.com', 20);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7900, 'JAMES', 'CHENNAI', 'CLERK', 29500, '23-JUN-2000', 350, 'james@aol.com', 30);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7934, 'MILLER', 'MUMBAI', 'CLERK', 33000, '21-JAN-2001', 290, 'miller@hotmail.com', 10);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7902, 'FORD', 'BANGALORE', 'ANALYST', 50000, '13-JUN-1993', 600, 'ford@gmail.com', 20);
 insert into employee (emp_id, emp_name, emp_city, emp_job, emp_salary, emp_join_date, emp_commission, email_id, emp_dept_no) values (7654, 'MARTIN', 'CHENNAI', 'SALESMAN', 22500, '05-DEC-1998', '', 'martin@yahoo.com', 30);
 
 
 COMMIT;

/*
 * 		Year 2018, MAY
 *
 *		Set 5 - DML/Query Statements
 */
 
 
 -- Question 1.1
 
 select * from employee
 order by emp_name desc;
  
 
 -- Question 1.2
 
 alter table employee
 add email_id varchar2(20) not null unique;
  
 
 -- Question 1.3 is repeat from previous year
 
 
 -- Question 1.4		
 
 select dep.dept_no, dep.dname, dep.location, 
 emp.emp_name, emp.emp_job, emp.emp_city, emp.email_id, emp.emp_salary, emp.emp_commission
 from dept dep
 left join employee emp on dep.dept_no = emp.emp_dept_no
 order by dep.dept_no;
 
 
 -- Question 1.5
 
 select * from employee
 where emp_salary = (select min(emp_salary) from employee);
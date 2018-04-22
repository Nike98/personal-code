
/*
 * 		Year 2017, MAY
 *
 *		Set 1 - DML/Query Statements
 */
 
 
 -- Question 1. a)
 
 select emp_name, emp_salary from employee
 order by emp_salary desc;
 
 
 -- Question 1. b)
 
 select count(*) as count, emp_dept_no from employee
 group by emp_dept_no;
 
 
 -- Question 1. c)
 
 select emp_name, emp_salary from employee
 where emp_salary >= 40000;
 
 
 -- Question 1. d)
 
 select emp_name from employee
 where emp_name like '_A%';
 
 
 -- Question 1. e)
 
 select count(emp_name) from employee
 having count(emp_name) like 'ACCOUNTANT';

/*
 * 		Year 2018, MAY
 *
 *		Set 2 - DML/Query Statements
 */
 
 
 -- Question 1.1
 
 select * from employee where emp_city = 'DELHI';
 
 
 -- Question 1.2
 
 
 
 
 -- Question 1.3
 
 select * from employee
 where emp_salary * 12 > 500000;
 
 
 -- Question 1.4
 
  select avg(emp_salary), emp_dept_no
  from employee
  group by emp_dept_no;
  
  
  -- Question 1.5
  
  select emp_name, emp_salary from employee
  where emp_salary = (select max(emp_salary) from employee);
 
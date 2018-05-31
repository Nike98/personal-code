
/*
 * 		Year 2018, MAY
 *
 *		Set 3 - DML/Query Statements
 */
 
 
 -- Question 1.1
 
 select client_no, name
 from client
 where name like '_A%';
 
 
 -- Question 1.2
 
 select name, city
 from client
 where city like 'M%';
 
 
 -- Question 1.3
 
 select name, city
 from client
 where city = 'PUNE' or city = 'MUMBAI';
 
 
 -- Question 1.4
 
 select * from client where bal_due > 1000;
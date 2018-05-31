
/*
 * 		Year 2018, MAY
 *
 *		Set 1 - DML/Query Statements
 */
 
 
 -- Question 1.1
 
 
 
 
 -- Question 1.2
 
 alter table 
 add email_id varchar2(30) unique;
 
 
 -- Question 1.3
 
 select count(stud_id), course_id
 from student3
 group by course_id;
 
 
 -- Question 1.4
 
 delete from student3 where city = 'PUNE';
 
 
 -- Question 1.5
 
 update course
 set fees = fees + (fees * 5 / 100);
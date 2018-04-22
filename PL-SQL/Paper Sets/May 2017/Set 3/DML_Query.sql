
/*
 * 		Year 2017, MAY
 *
 *		Set 3 - DML/Query Statements
 */
 
 
 -- Question 1. A]
 -- a)
 
 select * from student2
 where to_char(dob, 'MON') = 'MAY';
 
 
 -- b)
 
 select * from student2
 where course_enrolled = 'MBA' or course_enrolled = 'MA';
 
 
 -- c)
 
 select * from classes
 where max_stud_allowed = 60;
 
 
 -- d)
 
 select course_name, course_fees from course group by course_name;
 
 
 -- e)
 
 select * from student2
 where city = 'MUMBAI';
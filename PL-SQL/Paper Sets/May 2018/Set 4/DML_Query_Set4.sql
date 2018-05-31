
/*
 * 		Year 2018, MAY
 *
 *		Set 4 - DML/Query Statements
 */
 
 
 -- Question 1.1
 
 update course
 set fees = fees + (fees * 10 / 100);
 
 
 -- Question 1.2
 
 select count(fees_paid) as mca_total from enrollment where course_id = 120;
 
 
 -- Question 1.3
 
 select course_id from enrollment where course_id = (select max(count(course_id)) from enrollment group by course_id);
 
 
 -- Question 1.4
 
 select * from course
 where course_id = (select course_id from (select course_id, count(student_id) as total
 from enrollment group by course_id order by total desc) where rownum = 1);
 
 
 -- Question 1.5
 
 delete from enrollment where student_id in 
(select e.student_id from enrollment e inner join course c on e.course_id = c.course_id and fees_paid < fees);
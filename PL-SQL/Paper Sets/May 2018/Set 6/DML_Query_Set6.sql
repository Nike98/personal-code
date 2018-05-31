
/*
 * 		Year 2018, MAY
 *
 *		Set 6 - DML/Query Statements
 */
 
 
 -- Question 1.1
 -- These are just a few fields for example purpose. More fields can be added.
 
 select stud.stud_id, stud.name, stud.address, cor.course_id, cor.cname, enrol.enrollment_dt
 from enrollment enrol, course cor, student3 stud
 where enrol.student_id = stud.stud_id
 and enrol.course_id = cor.course_id
 and to_char(enrol.enrollment_dt,'Mon') = to_char(sysdate,'Mon');
 
 -- Question 1.2
 
 select * from student3 where stud_id not in (select student_id from enrollment);
 -- OR
 select * from student3 where 
 not exists (select student_id from enrollment where student3.stud_id=enrollment.student_id);
 
 
 -- Question 1.3
 
 select count(name), course_id
 from student3
 group by course_id;
 
 
 -- Question 1.4 is repeated
 
 
 -- Question 1.5 
 
 alter table student3
 add email_id varchar2(20) unique;
 
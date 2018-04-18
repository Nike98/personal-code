
 -- Creating the TABLE
 create table Student
 (
	stud_id number(3,0) constraints stud_id_pk primary key,
	stud_name varchar2(10) not null,
	stud_dob date not null,
	stud_city varchar2(10) not null,
	stud_course_enrolled varchar2(4) constraints stud_course_check check((stud_course_enrolled in ('BCOM', 'BCA', 'BBA')))
 );
 
 
 -- Adding data to it
 
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(1, 'NIKHIL', '20-FEB-1998', 'MUMBAI', 'BCA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(2, 'DHAVAL', '16-MAR-1988', 'PUNE', 'BCA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(3, 'YASH', '01-JAN-1998', 'RAJKOT', 'BCA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(4, 'HARSHAL', '21-APR-2000', 'MUMBAI', 'BCOM');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(5, 'QADIR', '05-DEC-1995', 'KANPUR', 'BBA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(6, 'SUBHAJIT', '08-OCT-1993', 'KOLKATA', 'BBA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(7, 'DANISH', '26-MAY-1995', 'KOLAPUR', 'BBA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(8, 'ROSHAN', '18-SEP-1996', 'MUMBAI', 'BBA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(9, 'NISARG', '20-NOV-1998', 'MUMBAI', 'BCA');
 insert into student (stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled) values(10, 'ASHISH', '14-FEB-1998', 'MUMBAI', 'BCA');
 
 commit;


 -- Creating Table Course
 
 create table course
 (
	course_id number(3,0) constraints course_id_pk primary key,
	cname varchar2(5) unique,
	duration number(1) not null,
	fees number(6,0) not null
 );
 
 
 -- Creating Table Student3

 create table student3
 (
	stud_id number(2,0) constraints stud3_id_pk primary key,
	name varchar2(15) not null,
	address varchar2(20) not null,
	city varchar2(15) not null,
	dt_of_birth date not null,
	admit_dt date not null,
	mobile_no varchar2(13) unique,
	email_id varchar2(30) unique
 );
 
 -- Creating Table Enrollment
 
 create table enrollment
 (
	student_id number(2,0) constraints stud_id_fk_enrollment references student3(stud_id),
	course_id number(3,0) constraints course_id_fk_enrollment references course(course_id),
	enrollment_dt date not null,
	fees_paid number(6,0) not null
 );
 
 -- Adding Data to the Table Course
 
 insert into course (course_id, cname, duration, fees) values (100, 'BCA', 3, 240000);
 insert into course (course_id, cname, duration, fees) values (120, 'MCA', 3, 180000);
 insert into course (course_id, cname, duration, fees) values (241, 'BBA', 3, 180000);
 insert into course (course_id, cname, duration, fees) values (258, 'BCOM', 3, 150000);
 insert into course (course_id, cname, duration, fees) values (269, 'MBA', 2, 200000);
 insert into course (course_id, cname, duration, fees) values (246, 'BMS', 3, 180000);
 insert into course (course_id, cname, duration, fees) values (346, 'BA', 3, 300000);
 insert into course (course_id, cname, duration, fees) values (365, 'MA', 2, 240000);
 
 -- Adding Data to Table Student3
 
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (1, 'NIKHIL', 'ULWE', 'MUMBAI', '20-FEB-1998', '20-MAY-2018', 0123456789);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (2, 'DHAVAL', 'GANDHINAGAR', 'PUNE', '16-MAR-1988', '16-JUN-2017', 1234567890);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (3, 'YASH', 'NYARI DAM', 'RAJKOT', '01-JAN-1995', '31-MAY-2018', 2345678901);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (4, 'HARSHAL', 'RAJWADA', 'INDORE', '21-APR-2000', '26-MAY-2018', 3456789012);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (5, 'QADIR', 'KING EDWARD RD.', 'KANPUR', '05-DEC-1989', '05-JUN-2017', 4567890123);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (6, 'SUBHAJIT', 'PARK STREET', 'KOLKATA', '08-OCT-1993', '19-MAY-2017', 5678901234);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (7, 'DANISH', 'PANTNAGAR', 'ALIBAUG', '26-MAY-1995', '01-JUN-2017', 6789012345);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (8, 'ROSHAN', 'MALAD', 'MUMBAI', '18-SEP-1996', '16-MAY-2017', 7890123456);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (9, 'NISARG', 'THANE GAON', 'MUMBAI', '20-NOV-1998', '19-MAY-2018', 8901234567);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (10, 'ASHISH', 'THANE GAON', 'MUMBAI', '14-FEB-1998', '18-JUN-2018', 9012345678);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (11, 'RITHIK', 'THEVARA', 'KOCHI', '15-OCT-1999', '15-MAY-2017', 9013267342);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (12, 'MAHESH', 'BICHPURI', 'AGRA', '05-JAN-1993', '06-JUN-2018', 8850634252);
 insert into student3 (stud_id, name, address, city, dt_of_birth, admit_dt, mobile_no) values (13, 'MADHAVENDRA', 'CIVIL LINES', 'BALLIA', '05-JAN-1993', '06-JUN-2018', 1234567899);
 
 -- Adding Data to Table Enrollment
 
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (1, 100, '30-APR-2018', 240000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (2, 100, '15-MAY-2017', 240000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (3, 100, '20-MAY-2018', 240000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (4, 258, '25-MAY-2018', 50000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (5, 241, '11-MAY-2017', 90000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (6, 241, '08-APR-2017', 120000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (7, 241, '24-MAY-2017', 50000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (8, 258, '05-MAY-2017', 100000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (9, 100, '09-MAY-2018', 120000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (10, 100, '01-MAY-2018', 240000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (11, 346, '15-APR-2017', 140000);
 insert into enrollment (student_id, course_id, enrollment_dt, fees_paid) values (12, 365, '18-MAY-2018', 240000);
 
 -- COMMIT
 
 COMMIT;
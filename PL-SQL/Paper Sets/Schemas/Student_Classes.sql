
 -- Creating the TABLE Student2
 
 create table student2
 (
	roll_no number(2,0) constraints roll_no_pk primary key,
	name varchar2(10) not null,
	lastname varchar2(10) not null,
	course_enrolled varchar2(5),
	dob date not null,
	city varchar2(10) not null
 );
 
 
 -- Creating the Table Classes
 
 create table classes
 (
	dept varchar2(10) not null,
	course varchar2(5) not null,
	max_stud_allowed number(5,0) not null,
	current_students number(5,0) not null,
	constraints cuur_stud_check_with_max check (current_students <= max_stud_allowed)
 );
 
 
 -- Altering the TABLE Student2 to add Mobile_No column
 
 alter table student2
 add mobile_no number(10,0) not null;
 
 
 -- Adding Data to the TABLE Student2
 
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (1, 'NIKHIL', 'AGARWAL', 'BCA', '20-FEB-1998', 'MUMBAI', 0123456789);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (2, 'DHAVAL', 'ANJARIA', 'BCA', '16-MAR-1988', 'PUNE', 1234567890);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (3, 'YASH', 'ATISHAY', 'BCA', '01-JAN-1998', 'RAJKOT', 2345678901);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (4, 'HARSHAL', 'JAIN', 'BCOM', '21-APR-2000', 'MUMBAI', 3456789012);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (5, 'QADIR', 'SAILANI', 'BBA', '05-DEC-1995', 'CHENNAI', 4567890123);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (6, 'SUBHAJIT', 'MONDAL', 'BBA', '08-OCT-1993', 'KOLKATA', 5678901234);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (7, 'DANISH', 'VYAS', 'BBA', '26-MAY-1995', 'KOLAPUR', 6789012345);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (8, 'ROSHAN', 'KHARE', 'BBA', '18-SEP-1996', 'MUMBAI', 7890123456);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (9, 'NISARG', 'PATIL', 'BCA', '20-NOV-1998', 'MUMBAI', 8901234567);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (10, 'ASHISH', 'CHAUHAN', 'BCA', '14-FEB-1998', 'MUMBAI', 9012345678);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (11, 'RITHIK', 'SUKHIJA', 'BA', '15-OCT-1999', 'KOCHIN', 9013267342);
 insert into student2 (roll_no, name, lastname, course_enrolled, dob, city, mobile_no) values (12, 'MAHESH', 'KHEDEKAR', 'MA', '05-JAN-1993', 'AGRA', 8850634252);
 
 
 -- Adding Data to the Table Classes
 
 insert into classes (dept, course, max_stud_allowed, current_students) values ('COMPUTER', 'BCA', 80, 70);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('COMPUTER', 'MCA', 80, 50);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('BUSINESS', 'BBA', 90, 60);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('BUSINESS', 'BCOM', 60, 50);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('MANAGEMENT', 'MBA', 40, 40);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('MANAGEMENT', 'BMS', 50, 45);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('ARTS', 'BA', 30, 29);
 insert into classes (dept, course, max_stud_allowed, current_students) values ('ARTS', 'MA', 30, 25);
 
 
 -- Commit everything
 
 commit;
 
 
 
 
 /* select emp_name, emp_join_date from employee where (emp_join_date < (select emp_join_date from employee where emp_name = 'IBSAR')); */
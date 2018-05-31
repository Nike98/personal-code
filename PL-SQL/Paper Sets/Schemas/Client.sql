
 -- Creating Table Client
 
 create table client
 (
	client_no number(4,0) constraints client_no_pk primary key,
	name varchar2(20) not null,
	address varchar2(20) not null,
	city varchar2(15) not null,
	mobile number(10,0) not null,
	email_id varchar2(30) not null,
	bal_due number(6,0) not null
 );
 
 
 -- Inserting Data into Table Client
 
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1369, 'NIKHIL', 'ULWE', 'MUMBAI', 0123456789, 'nikhilagarwal@yahoo.com', 15000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1499, 'DHAVAL', 'GANDHINAGAR', 'PUNE', 1234567890, 'dhavalanjaria@gmail.com', 100000); 
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1521, 'YASH', 'NYARI DAM', 'RAJKOT', 2345678901, 'yashatishay@aol.com', 62000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1566, 'HARSHAL', 'RAJWADA', 'INDORE', 3456789012, 'harshaljain@gmail.com', 25800);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1698, 'QADIR', 'KING EDWARD RD.', 'KANPUR', 4567890123, 'qadirsailani@gmail.com', 300000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1782, 'SUBHAJIT', 'PARK STREET', 'KOLKATA', 5678901234, 'subhajitmondal@yahoo.com', 125000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (1788, 'DANISH', 'PANTNAGAR', 'ALIBAUG', 6789012345, 'vyasdanish@hotmail.com', 226000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (2839, 'ROSHAN', 'MALAD', 'MUMBAI', 7890123456, 'khare@aol.com', 152000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (2844, 'NISARG', 'THANE GAON', 'MUMBAI', 8901234567, 'nisargpatil@yahoo.com', 100000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (2876, 'ASHISH', 'THANE GAON', 'MUMBAI', 9012345678, 'ashishchauhan@yahoo.com', 600000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (2900, 'RITHIK', 'THEVARA', 'KOCHI', 9013267342, 'sukhija@gmail.com', 346000);
 insert into client (client_no, name, address, city, mobile, email_id, bal_due) values (2934, 'MAHESH', 'BICHPURI', 'AGRA', 8850634252, 'maheshkhed@yahoo.com', 365000);
 
 
 COMMIT;
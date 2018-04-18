
 -- Create Table Product
 
 create table product
 (
	prod_id number(5,0) constraints prod_id_pk primary key,
	prod_name varchar2(20) not null,
	prod_warranty number(2,0) not null,
	prod_price number(5,0) not null
 );
 
 
 -- Create Table Customer
 
 create table customer
 (
	cust_id number(2,0) constraints cust_id_pk primary key,
	cust_name varchar2(20) not null,
	cust_place varchar2(20) not null,
	cust_mobile_no number(10,0) not null,
	prod_id number(5,0) constraints prod_id_fk references product(prod_id),
	date_of_purchase date not null
 );
 
 
 -- Insert Data into Table Product
 
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (1001, 'GUITAR', '12', '10000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (1005, 'SITAR', '18', '15000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (2010, 'CARPET', '6', '1000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (2020, 'DUMBLE', '12', '8000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (3022, 'RADIO', '18', '12000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (3023, 'XIAOMI MOBILE', '12', '20000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (4028, 'PS4', '24', '40000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (4041, 'PS4 DISC', '6', '4000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (5045, 'HOVERBOARD', '12', '17000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (5049, 'MARSHALL SPEAKERS', '12', '25000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (6051, 'SWISS KNIFE', '6', '9000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (6056, 'LAPTOP', '24', '70000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (7064, 'HEADPHONES', '12', '17000');
 insert into product (prod_id, prod_name, prod_warranty, prod_price) values (7087, 'LCD', '36', '80000');
 
 
 -- Insert Data into Table Customer
 
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (1, 'CERCEI LANNISTER', 'KINGS LANDING', 9012345678, 6051, to_date('25-MAY-2011 10:34:09 A.M.', 'dd-mon-yyyy hh:mi:ss A.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (2, 'JAMIE LANNISTER', 'KINGS LANDING', 2345678901, 6056, to_date('18-DEC-2013 04:18:56 A.M.', 'dd-mon-yyyy hh:mi:ss A.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (3, 'TYRION LANNISTER', 'DRAGONSTONE', 1234567890, 3022, to_date('02-JAN-2012 08:44:09 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (4, 'ARYA STARK', 'WINTERFELL', 8901234567, 6056, to_date('01-JAN-2010 12:01:01 A.M.', 'dd-mon-yyyy hh:mi:ss A.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (5, 'SANSA STARK', 'WINTERFELL', 6789012345, 2010, to_date('23-AUG-2015 02:26:15 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (6, 'BRIAN STARK', 'WINTERFELL', 2234567899, 5045, to_date('25-DEC-2014 11:01:12 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (7, 'JON SNOW', 'THE WALL', 7890123456, 4028, to_date('18-JUL-2012 05:20:45 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (8, 'DAENERYS TARGARYEN', 'DRAGONSTONE', 3456789012, 3023, to_date('29-APR-2013 01:45:12 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (9, 'TORMUND', 'BEYOND THE WALL', 4567890123, 5049, to_date('04-OCT-2014 09:56:17 A.M.', 'dd-mon-yyyy hh:mi:ss A.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (10, 'YGRITTE', 'BEYOND THE WALL', 5678901234, 1001, to_date('15-SEP-2013 10:15:00 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (11, 'JOHN', 'UKRAINE', 0123456789, 7087, to_date('05-FEB-2010 12:15:15 P.M.', 'dd-mon-yyyy hh:mi:ss P.M.'));
 insert into customer (cust_id, cust_name, cust_place, cust_mobile_no, prod_id, date_of_purchase)
	values (12, 'SAM', 'AMAZON FOREST', 5598262987, 7087, to_date('01-MAY-2012 02:25:00 A.M.', 'dd-mon-yyyy hh:mi:ss A.M.'));
	
 -- Commit all the Changes made
 
 COMMIT;
 
 /*
  * 1.
  * 	a) select * from product where prod_price = (select min(prod_price) from product);
  *
  * 	b) select cust_name from customer
  * 	   where to_char(date_of_purchase, 'yyyy') = '2010'
  * 	   and prod_id in (select prod_id from product where prod_name = 'LAPTOP');
  *
  * 	d) 
  */
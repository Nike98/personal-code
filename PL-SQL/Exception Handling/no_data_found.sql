
/*
 * This is a basic example to show Exception Handling
 * in PL/SQL. If no data is found in the Table then the 
 * EXCEPTION is raised.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	id customer.cust_id%TYPE;
	name customer.cust_name%TYPE;
	city customer.cust_place%TYPE := 'MUMBAI';
 
 BEGIN
 
	select cust_id, cust_name, cust_place into id, name, city
	from customer
	where cust_place = city;
	
	dbms_output.put_line(chr(10) || '############################################################' || chr(10));
	dbms_output.put_line(chr(9) || 'ID : ' || id);
	dbms_output.put_line(chr(9) || 'Name : ' || name);
	dbms_output.put_line(chr(9) || 'City : ' || city);
	dbms_output.put_line(chr(10) || '############################################################');
	
 EXCEPTION
 
	WHEN no_data_found then
		dbms_output.put_line(chr(10) || ' No such Entry');
		
	WHEN others then
		dbms_output.put_line(chr(10) || ' Error !');
 
 END;
 /

/*
 * 		Year 2017, MAY
 *
 *		Set 2 - DML/Query Statements
 */
 
 
 -- Question 1. a)
 
  select cust_id, cust_name, to_char(date_of_purchase, 'dd-MON-yyyy hh:mi:ss A.M.') as Purchse_date
  from customer
  where prod_id in (select prod_id from product where prod_name = 'LCD')
  and cust_name = 'SAM';
   
 
 -- Question 1. b)
 
 select * from customer
 where cust_mobile_no like '88%';
 
 
 -- Question 1. c)
 
 select * from customer
 where cust_place = 'DELHI';
  
 
 -- Question 1. d)
 
 select sum(prod_price) as total from product;
  
 
 -- Question 1. e)
 
 select * from product
 where prod_warranty > 12*5;
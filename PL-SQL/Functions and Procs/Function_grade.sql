/*
 * This program is the basic implementation
 * of giving a particular rating based on
 * an integer input from the user with
 * method of creating a function for it.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
	-- Creating the Function
 CREATE OR REPLACE FUNCTION rating_msg(rating in number) return varchar2
 AS
 BEGIN
 
	if rating > 7 then
		return ' It is Great';
	elsif rating >= 5 then
		return ' It is just ok-ish';
	else
		return ' It is pretty bad';
	end if;
	
 END;
 /
 
	-- Calling the Function
 DECLARE
 
	rate number := &rate;
 
 BEGIN
 
	dbms_output.put_line(chr(10) || rating_msg(rate));
 
 END;
 /
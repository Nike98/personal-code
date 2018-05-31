/*
 * Write a PL/SQL block to accept 2 numbers from the User and
 * perform Addition and Multiplication operation on them.
 */
 
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	num1 number(2,0) := &num1;			-- Initializing the Variable num1 and taking the input also
	num2 number(2,0) := &num2;			-- Initializing the Variable num2 and taking the input also
	ans number(3,0);
 
 BEGIN
 
	ans := num1 + num2;
	dbms_output.put_line(chr(10) || ' The Addition = ' || ans);
	
	ans := num1 * num2;
	dbms_output.put_line(chr(10) || ' The Multiplication = ' || ans);
 
 END;
 /
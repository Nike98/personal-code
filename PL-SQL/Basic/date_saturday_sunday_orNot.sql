/*
 * Write a PL/SQL program to check whether a date 
 * falls on weekend i.e. SATURDAY or SUNDAY.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	dt_inp date := TO_DATE('&new_dt', 'dd-mon-yyyy');
	get_day varchar2(15);
 
 BEGIN
 
	get_day := RTRIM(TO_CHAR(dt_inp, 'day'));
	
	if (get_day in ('saturday', 'sunday'))
	then
		dbms_output.put_line(chr(10) || 'The day of the given date is: ' || UPPER(get_day));
	else
		dbms_output.put_line(chr(10) || 'The day of the given date is ' || UPPER(get_day) 
			|| ' and it is not SATURDAY or SUNDAY');
	end if;
 
 END;
 /
/*
 * Write a PL/SQL program to convert a temperature from 
 * Fahrenheit to Celsius and vice versa.
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	temp number := &temperature;
	t_scale char := '&temp_scale';
	new_temp number;
	new_scale char;
 
 BEGIN
 
	if t_scale != 'c' and t_scale != 'f'
	then
		dbms_output.put_line(chr(10) || 'Invalid Temperatue Scale input');
	else
		if t_scale = 'c'
		then
			new_temp := ((9 * temp) / 5) + 32;
			new_scale := 'F';
		else
			new_temp := ((temp - 32) * 5) / 9;
			new_scale := 'C';
		end if;
		
		dbms_output.put_line(chr(10) || 'The new Temperatue in scale "' || new_scale || '" is: ' || new_temp);
	end if;
	
 
 END;
 /
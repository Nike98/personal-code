

/*
 * Write a PL/SQL code to calculate the total and the percentage ofmarks of
 * the students in four subjects from the table-Student withthe schema given
 * below.STUDENT ( RNO, S1 , S2, S3, S4, total, percentage).
 */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 DECLARE
 
	CURSOR cur_stu
	IS
		SELECT RNO, (S1 + S2 + S3 + S4), ((S1 + S2 + S3 + S4) / 4)
		FROM student;
		
	rno student.rno%TYPE;
	total int;
	percentage float;
 
 BEGIN
	 
	OPEN cur_stu;

	dbms_output.put_line(chr(10) || ' Roll No' || chr(9) || 'Total' || chr(9) || 'Percentage');
	
	LOOP
	
		FETCH cur_stu INTO rno, total, percentage;
		
		EXIT WHEN cur_stu%NOTFOUND;
		
		dbms_output.put_line(chr(10) || ' ' || rno || chr(9) || chr(9) || total || chr(9) || percentage);
	
	END LOOP;
	
	CLOSE cur_stu;
	 
 END;
 /
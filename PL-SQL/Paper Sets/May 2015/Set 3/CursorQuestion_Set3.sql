/*
 * Before Running this File on your SQL Command Line,
 * Please have a look at the schema_data.sql and run
 * it in your command line to get the Student table.
 *
 * This will do nothing but create a SAMPLE
 * Student table for you with data in it.
 * And all the manipulation will done in that table itself.
 *
 */
 
 /*
  * c) Write a Cursor block to retrieve the details of the Students living in 'MUMBAI'
  */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	CURSOR cur_stu					-- Declaring the CURSOR to be used
	IS
		select stud_id, stud_name, stud_dob, stud_city, stud_course_enrolled
		from student																-- Select statement to be Executed
		where stud_city = 'MUMBAI';
		
	id student.stud_id%TYPE;							-- Variable to store the ID of the Student
	name student.stud_name%TYPE;						-- Variable to store the Name of the Student
	dob student.stud_dob%TYPE;							-- Variable to store the DOB of the Student
	city student.stud_city%TYPE;						-- Variable to store the City of the Student
	course student.stud_course_enrolled%TYPE;			-- Variable to store the Course of the Student
 
 BEGIN
 
	OPEN cur_stu;					-- Opens the Cursor
	
	if cur_stu%ISOPEN then		-- If the Cursor ISOPEN then execute the further statements
	
		dbms_output.put_line(chr(10) || '#########################################################' || chr(10));
		
		loop
		
			FETCH cur_stu into id, name, dob, city, course;			-- Fetches the data into the Local Variables
			
			exit when cur_stu%NOTFOUND;								-- If nothing is found in the table so exit the Cursor
			
			if cur_stu%FOUND then
		
				dbms_output.put_line(chr(9) || ' Student ID : ' || id);
				dbms_output.put_line(chr(9) || ' Student Name : ' || name);
				dbms_output.put_line(chr(9) || ' Student dob : ' || dob);
				dbms_output.put_line(chr(9) || ' Student city : ' || city);
				dbms_output.put_line(chr(9) || ' Student Course : ' || course);
				dbms_output.put_line(chr(9));
			
			end if;
			
		end loop;
		
		dbms_output.put_line(chr(10) || '#########################################################');
		
	else
	
		dbms_output.put_line(chr(10) || ' There was a problem opening the Cursor.');
	
	end if;
	
	CLOSE cur_stu;				-- Closes the Cursor
 
 END;
 /
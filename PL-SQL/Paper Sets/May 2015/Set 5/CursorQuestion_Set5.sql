
/*
 * Before Running this File on your SQL Command Line,
 * Please have a look at the schema_data.sql and run
 * it in your command line to get the student2 table.
 *
 * This will do nothing but create a SAMPLE
 * student2 table for you with data in it.
 * And all the manipulation will done in that table itself.
 *
 */
 
 /*
  * b) Use a Cursor to find the details of the Students who are living in 'CHENNAI'
  */
 
 SET SERVEROUTPUT ON;
 SET VERIFY OFF;
 
 
 DECLARE
 
	CURSOR cur_stu					-- Declaring the CURSOR to be used
	IS
		select roll_no, name, lastname, dob, city, mobile_no
		from student2																-- Select statement to be Executed
		where city = 'CHENNAI';
		
	roll student2.roll_no%TYPE;							-- Variable to store the Roll No of the student2
	fname student2.name%TYPE;							-- Variable to store the First Name of the student2
	lname student2.lastname%TYPE;						-- Variable to store the Last Name of the student2
	dob student2.dob%TYPE;								-- Variable to store the DOB of the student2
	city student2.city%TYPE;							-- Variable to store the City of the student2
	mob student2.mobile_no%TYPE;						-- Variable to store the Mobile Number of the student2
 
 BEGIN
 
	OPEN cur_stu;					-- Opens the Cursor
	
	if cur_stu%ISOPEN then			-- If the Cursor ISOPEN then execute the further statements
	
		dbms_output.put_line(chr(10) || '#########################################################' || chr(10));
		
		loop
		
			FETCH cur_stu into roll, fname, lname, dob, city, mob;			-- Fetches the data into the Local Variables
			
			exit when cur_stu%NOTFOUND;								-- If nothing is found in the table so exit the Cursor
			
			if cur_stu%FOUND then
		
				dbms_output.put_line(chr(9) || ' Student Roll No : ' || roll);
				dbms_output.put_line(chr(9) || ' Student First Name : ' || fname);
				dbms_output.put_line(chr(9) || ' Student Last Name : ' || lname);
				dbms_output.put_line(chr(9) || ' Student DOB : ' || dob);
				dbms_output.put_line(chr(9) || ' Student City : ' || city);
				dbms_output.put_line(chr(9) || ' Student Mobile Number : ' || mob);
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
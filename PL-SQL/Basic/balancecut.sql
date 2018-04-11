/*
 * This program debits the Account
 * of the Users whose balance is lower 
 * than the set low balance rate.
 */

SET SERVEROUTPUT ON;
SET VERIFY OFF;

Declare
	mCur_Bal Number (10,2);
	Acct_No1 varchar2 (7);
	Fine number(3) := 100;
	Min_Bal constant number (7,2) := 3000.00;
	latest_bal number(10,2);
	
Begin 
	Acct_No1 := &Acct_No;
	
	Select Cur_bal INTO mCur_Bal From Acct_Mstr Where Acct_No = Acct_No1;
	
	If mCur_Bal < Min_Bal Then
		Update Acct_Mstr SET Cur_bal = mCur_bal - Fine
		Where Acct_No = Acct_No1;
		dbms_output.put_line(chr(13));
		dbms_output.put_line('===============================');
		dbms_output.put_line('Balance cut for account no: ' || Acct_No1);
		dbms_output.put_line('===============================');
		dbms_output.put_line(chr(13));
		select cur_bal into latest_bal from acct_mstr where acct_no = Acct_No1;
		dbms_output.put_line('New Balance is : ' || latest_bal);
		COMMIT;
		
	ELSE
		dbms_output.put_line('=====================================');
		dbms_output.put_line('Balance sufficent for account no: ' || Acct_No1);
		dbms_output.put_line('=====================================');
		
	End If;
End;
/
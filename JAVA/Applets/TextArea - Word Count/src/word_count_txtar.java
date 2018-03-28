/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Basic example of and Applet to display a Frame
 * 		and a TextArea in which the User inputs some
 * 		text and 2 Labels on top it which display the 
 * 		Word count and Character count.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.Frame;
import java.awt.Button;
import java.awt.Label;
import java.awt.TextArea;
import java.awt.event.*;

public class word_count_txtar {

	public static void main(String[] args) {
		
		Frame frame = new Frame("Count Words and Characters");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		TextArea txar1 = new TextArea();
		txar1.setBounds(50, 100, 300, 200);
		
		Label lblWord = new Label("Words : ");
		lblWord.setBounds(60, 50, 100, 30);
		
		Label lblCount = new Label("Count : ");
		lblCount.setBounds(200, 50, 100, 30);
		
		Button btnCalc = new Button("Calculate");
		btnCalc.setBounds(150, 320, 100, 50);
		btnCalc.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				
				String text = txar1.getText();
				String words[] = text.split("\\s");
				
				lblWord.setText("Words : " + words.length);
				lblCount.setText("Count : " + text.length());
			}
			
		});
		
		frame.add(txar1);
		frame.add(lblWord);
		frame.add(lblCount);
		frame.add(btnCalc);
	}

}

/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		Basic example of and Applet to display a Frame
 * 		and 3 labels which take integer inputs from the
 * 		User and Display the Addition of those inputs.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.Frame;
import java.awt.Button;
import java.awt.TextField;
import java.awt.event.*;

import javax.swing.JOptionPane;

public class add {

	public static void main(String[] args) {
		
		Frame frame = new Frame("Addition Example");
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.setLocationRelativeTo(null);
		
		TextField txf1 = new TextField();
		txf1.setBounds(125, 100, 150, 20);
		
		TextField txf2 = new TextField();
		txf2.setBounds(125, 150, 150, 20);
		
		TextField txf3 = new TextField();
		txf3.setBounds(125, 200, 150, 20);
		
		Button btn1 = new Button("Add");
		btn1.setBounds(125, 250, 150, 50);
		btn1.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				
				int num1 = Integer.parseInt(txf1.getText());
				int num2 = Integer.parseInt(txf2.getText());
				int num3 = Integer.parseInt(txf3.getText());
				
				int sum = num1 + num2 + num3;
				
				JOptionPane.showMessageDialog(null, "The Sum = " + sum);
			}
			
		});
		
		frame.add(txf1);
		frame.add(txf2);
		frame.add(txf3);
		frame.add(btn1);
	}

}

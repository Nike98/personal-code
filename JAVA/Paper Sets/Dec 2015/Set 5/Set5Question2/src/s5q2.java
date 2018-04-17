/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to create an Applet and show the working of a Calculator.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.util.*;
import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

/*
 * <applet code="s5q2" height=400 width=400>
 * </applet>
 */

public class s5q2 extends JApplet {
	
	// Declaration of the components to be used
	Panel buttonPanel;
	Panel operatorPanel;
	
	Button[] numButtons = new Button[9];
	Button[] operators = new Button[4];
	
	TextField text;
	
	// Setting the Font
	Font mFont = new Font("Tahoma", Font.PLAIN, 13);
	
	public void init() {

		buttonPanel = new Panel();
		operatorPanel = new Panel();
		
		// Adding the Buttons set in the Array
		// Adding the Buttons created to the buttonPanel
		for ( int i = 1 ; i < 10 ; i++ ) {
			
			numButtons[i - 1] = new Button(i + "");
			numButtons[i - 1].setFont(mFont);
			buttonPanel.add(numButtons[i - 1]);
		}
		
		// Setting the Grid and the Layout of the Button and Operator Panel
		buttonPanel.setLayout(new GridLayout(3, 3));
		operatorPanel.setLayout(new GridLayout(1, 4));
		
		// Setting up the TextField and it's Size
		text = new TextField(13);
		text.setFont(mFont);
		text.setPreferredSize(new Dimension(100, 10));
		
		this.setLayout(new GridLayout(4, 1));
		buttonPanel.setPreferredSize(new Dimension(200, 500));
		operatorPanel.setPreferredSize(new Dimension(200, 500));
		
		// Adding the Operator Buttons
		operators[0] = new Button("+");
		operators[1] = new Button("-");
		operators[2] = new Button("*");
		operators[3] = new Button("/");
		
		// Adding them to the Panel and Setting Font
		for ( int i = 0 ; i < 4 ; i++ ) {
			
			operators[i].setFont(mFont);
			operatorPanel.add(operators[i]);
		}
		
		add(text);
		add(buttonPanel);
		add(operatorPanel);
	}
	
	public void paint(Graphics g) {
		
		Queue<Integer> operation = new LinkedList<Integer>();
		
		operation.add(12);
		operation.add(12);
		operation.add(operation.remove() + operation.remove());
		showStatus(operation.remove() + "");
	}
}

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class rgb_scroller extends JFrame implements AdjustmentListener {

	private JLabel lblRed, lblGreen, lblBlue;
	private JScrollBar scbRed, scbGreen, scbBlue;
	
	// Initializing the Scroll Bar as the Constructor of the class
	public rgb_scroller() {
		
		// Setting up the Layout
		setLayout(new FlowLayout());
		
		// Initializing the Label for each Scroll Bar
		lblRed = new JLabel("Red");
		lblGreen = new JLabel("Green");
		lblBlue = new JLabel("Blue");
		
		// Initializing the Scroll Bar variables
		scbRed = new JScrollBar(JScrollBar.HORIZONTAL, 0, 5, 0, 255);
		scbGreen = new JScrollBar(JScrollBar.HORIZONTAL, 0, 5, 0, 255);
		scbBlue = new JScrollBar(JScrollBar.HORIZONTAL, 0, 5, 0, 255);
		
		// Adding the Scroll Bar EventListeners
		scbRed.addAdjustmentListener(this);
		scbGreen.addAdjustmentListener(this);
		scbBlue.addAdjustmentListener(this);
		
		// Adding all the Components to the Frame
		add(lblRed);
		add(lblGreen);
		add(lblBlue);
		add(scbRed);
		add(scbGreen);
		add(scbBlue);
	} // End of Constructor
	
	@Override
	public void adjustmentValueChanged(AdjustmentEvent e) {
		
		// Getting current values of the Scroll Bars
		int valRed = scbRed.getValue();
		int valGreen = scbGreen.getValue();
		int valBlue = scbBlue.getValue();
		
		// Change the Background
		getContentPane().setBackground(new Color(valRed, valGreen, valBlue));
	} // End of Event Handler

}

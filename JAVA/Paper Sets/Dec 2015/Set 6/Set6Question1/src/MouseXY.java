/*
 * ######################################################################################
 * ######################################################################################
 * 
 * 		WAP to create an Applet that displays the current X, Y
 * 		coordinates in the Status Bar whenever the Mouse is Moved.
 * 
 * ######################################################################################
 * ######################################################################################
*/

import java.awt.*;
import java.awt.event.*;
import java.applet.Applet;

public class MouseXY extends Applet implements MouseListener, MouseMotionListener {

	int x, y;
	String msg;
	
	public void init() {
		
		addMouseListener(this);
		addMouseMotionListener(this);
	}
	
	@Override
	public void mouseDragged(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Dragged";
		repaint();
	}

	@Override
	public void mouseMoved(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Moved";
		repaint();
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Clicked";
		repaint();
	}

	@Override
	public void mousePressed(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Pressed";
		repaint();
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Released";
		repaint();
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Entered";
		repaint();
	}

	@Override
	public void mouseExited(MouseEvent e) {
		
		x = e.getX();
		y = e.getY();
		msg = "Mouse Exited";
		repaint();
	}
	
	public void paint(Graphics g) {
		
		g.setFont(new Font("Helvetica", Font.BOLD, 20));
		g.fillOval(x, y, 10, 10);
		g.drawString(x + "," + y, x + 10, y - 10);
		g.drawString(msg, x + 10, y + 20);
		showStatus(msg + " at " + x + "," + y);
	}

}

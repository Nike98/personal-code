
import java.awt.*;
import java.awt.event.*;

public class DrawCanvas extends Canvas implements MouseListener, MouseMotionListener{

	final int CircleSize = 50;		// Becomes circle radius to draw
	private Point lineBegin = new Point(0, 0);		// Point where the line starts by default
	
	public DrawCanvas() {
	
		addMouseListener(this);
		addMouseMotionListener(this);
	}
	
	@Override
	public void mouseDragged(MouseEvent e) {
		
		Graphics g = getGraphics();
		
		if ( e.isMetaDown() )			// Erase existing Graphics using an Oval
			g.fillOval(e.getX() - (CircleSize / 2), e.getY() - (CircleSize / 2), CircleSize, CircleSize);
		else
			g.drawLine(lineBegin.x, lineBegin.y, e.getX(), e.getY());
		
		lineBegin.move(e.getX(), e.getY());
	}

	@Override
	public void mouseMoved(MouseEvent e) {
			
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		
	}

	@Override
	public void mousePressed(MouseEvent e) {
		
		if ( e.isMetaDown() )		// For right mouse Button
			setForeground(getBackground());		// Match Foreground to background (for erasing effect)
		else
			setForeground(Color.black);		// set foreground for drawing
		
		lineBegin.move(e.getX(), e.getY());
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		
	}

	@Override
	public void mouseExited(MouseEvent e) {
		
	}

	
}

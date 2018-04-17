
import java.awt.*;

public class FreeHandDrawing extends Frame {

	public FreeHandDrawing () {
		
		Canvas cnvs = new DrawCanvas();			// Draws the layout of the main program 
		cnvs.setBackground(Color.cyan);	// Sets the default color of the Background as white
		add("Center", cnvs);
		
		setTitle("FREE HAND DRAWING");
		setSize(500, 500);
		setVisible(true);
	}
}

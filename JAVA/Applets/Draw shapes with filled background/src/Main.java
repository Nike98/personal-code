import java.awt.Color;

import javax.swing.JFrame;

public class Main {

	public static void main(String[] args) {
		JFrame frame = new JFrame("Draw shapes with background color");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		Shape shape = new Shape();
		shape.setBackground(Color.WHITE);
		
		frame.add(shape);
		frame.setSize(400, 210);
		frame.setLocationRelativeTo(null);
		frame.setVisible(true);
	}

}

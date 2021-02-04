import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFrame;

public class ColorChooser extends JFrame implements ActionListener {

	private JFrame frame;
	private JButton btn;
	private Container cont;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		ColorChooser cc = new ColorChooser();
		cc.setSize(400, 400);
		cc.setVisible(true);
		cc.setLocationRelativeTo(null);
		cc.setDefaultCloseOperation(EXIT_ON_CLOSE);
	}

	/**
	 * Create the application.
	 */
	public ColorChooser() {
		cont = getContentPane();
		cont.setLayout(new FlowLayout());
		
		btn = new JButton("Color");
		btn.addActionListener(this);
		
		cont.add(btn);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		Color defColor = Color.RED;
		Color color = JColorChooser.showDialog(this, "Select a Color", defColor);
		cont.setBackground(color);
	}

}

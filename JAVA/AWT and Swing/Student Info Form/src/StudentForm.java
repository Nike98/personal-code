import java.awt.GridLayout;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowListener;

import javax.swing.BorderFactory;
import javax.swing.ButtonGroup;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.JFrame;

public class StudentForm extends JFrame {
	
	private JPanel panel;
	private ImageIcon image;
	private JLabel lbl1;
	private JLabel lbl2;
	private JTextField txfCollegeName;
	private JTextField txfStudentName;
	private JTextField txfQualification;
	private JTextArea txaAddress;
	private JRadioButton rdbtnM;
	private JRadioButton rdbtnF;
	
	WindowListener wl = new WindowAdapter() {
		public void windowClosing(java.awt.event.WindowEvent e) { System.exit(0); };
	};
	
	public StudentForm() {
		panel = new JPanel();
		panel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
		panel.setLayout(new GridLayout(8, 0, 10, 5));
		
		lbl1 = new JLabel();
		panel.add(lbl1);
		lbl1.setIcon(new ImageIcon(getClass().getResource("sies_logo.jpg")));
		
		lbl2 = new JLabel("Select Gender");
		
		txfCollegeName = new JTextField("Enter College Name");
		txfStudentName = new JTextField("Enter Student Name");
		txfQualification = new JTextField("Enter Qualification");
		
		txaAddress = new JTextArea("Enter Address");
		
		panel.add(txfCollegeName);
		panel.add(txfStudentName);
		panel.add(txaAddress);
		panel.add(txfQualification);
		panel.add(lbl2);
		
		rdbtnM = new JRadioButton("Male");
		rdbtnF = new JRadioButton("Female");
		ButtonGroup bg = new ButtonGroup();
		bg.add(rdbtnM);
		bg.add(rdbtnF);
		
		panel.add(rdbtnM);
		panel.add(rdbtnF);
		
		add(panel);
		
		setSize(700, 700);
		setLocationRelativeTo(null);
		addWindowListener(wl);
	}
	
	public static void main(String[] args) {
		JFrame frame = new StudentForm();
		frame.setVisible(true);
	}
	
}

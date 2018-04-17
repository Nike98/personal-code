import java.awt.event.*;
import javax.swing.*;
import java.awt.*;
import java.util.*;

/*<applet code=Calculator height=300 width=300>
</applet>*/
public class Calculator extends JApplet {
    Panel buttonPanel;
    Button[] numberButtons = new Button[9];
    Button[] operators = new Button[4];
    Panel operatorPanel;

    TextField text;

    public void init() {

        buttonPanel = new Panel();
        operatorPanel = new Panel();

        for(int i = 1; i < 10; i++) {
            numberButtons[i - 1] = new Button(i + "");
            buttonPanel.add(numberButtons[i - 1]);
        }

        buttonPanel.setLayout(new GridLayout(3, 3));
        operatorPanel.setLayout(new GridLayout(1, 4));

        text = new TextField(13);
        text.setPreferredSize(new Dimension(200, 10));

        this.setLayout(new GridLayout(4, 1));
        buttonPanel.setPreferredSize(new Dimension(200, 500));
        operatorPanel.setPreferredSize(new Dimension(200, 500));


        operators[0] = new Button("+");
        operators[1] = new Button("-");
        operators[2] = new Button("/");
        operators[3] = new Button("*");

        for(int i = 0; i < 4; i++)
            operatorPanel.add(operators[i]);



        add(text);
        add(buttonPanel);
        add(operatorPanel);
    }

    public void paint(Graphics g) {
        Queue<Integer> operation = new LinkedList<Integer>();

        operation.add(12);
        operation.add(12);
        operation.add(operation.remove() + operation.remove());
        showStatus(operation.remove() + "") ;
    }
}
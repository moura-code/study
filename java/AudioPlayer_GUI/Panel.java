package study.java.AudioPlayer_GUI;

import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.ImageIcon;
import java.awt.*;
import java.nio.Buffer;


public class Panel extends JPanel{
    static final int SCREEN_WIDTH = 750;
	static final int SCREEN_HEIGHT = 500;
    JButton button1 = new JButton(new ImageIcon( System.getProperty("user.dir") +"\\study\\java\\AudioPlayer_GUI\\logo.png"));
    JButton button2 = new JButton();

    Panel(){
        this.setPreferredSize(new Dimension(SCREEN_WIDTH,SCREEN_HEIGHT));
		this.setFocusable(true);
        button1.setSize(10, 10);
		this.add(button1);
        
    }
    
}

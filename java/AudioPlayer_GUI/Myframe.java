package study.java.AudioPlayer_GUI;
import javax.swing.ImageIcon;
import javax.swing.JFrame;

public class Myframe extends JFrame{
    Panel panel = new Panel();
    Myframe(){
        
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Audio Player");
        this.add(panel);
        setlogo(new ImageIcon( System.getProperty("user.dir") +"\\study\\java\\AudioPlayer_GUI\\logo.png" ));
        this.pack();
        this.setVisible(true);
		this.setLocationRelativeTo(null);
        
    }


    public void setlogo(ImageIcon image){
        this.setIconImage(image.getImage());
    }
}

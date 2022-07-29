package study.java.AudioPlayer_GUI;


import java.awt.*;

import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.swing.*;
import java.awt.event.ActionListener;
import java.io.File;
import java.awt.event.ActionEvent;
import javax.sound.sampled.Clip;
public class Panel extends JPanel implements ActionListener  {
    static final int SCREEN_WIDTH = 550;
	static final int SCREEN_HEIGHT = 300;
    File file = new File(System.getProperty("user.dir") +"\\study\\java\\AudioPlayer_GUI\\musica.wav");
    
    boolean isnotplaying = true;
    ImageIcon icon = new ImageIcon( System.getProperty("user.dir") +"\\study\\java\\AudioPlayer_GUI\\logo.png");
    JButton button1 = new JButton();
    JButton button2 = new JButton();

   
    AudioInputStream audio;
    Clip clip; 

    public Panel() {
        
        this.setPreferredSize(new Dimension(SCREEN_WIDTH,SCREEN_HEIGHT));
        this.setLayout(new GridBagLayout());
        this.botom();
        this.add(button1);
       
        try {
            clip = AudioSystem.getClip();
            this.audio = AudioSystem.getAudioInputStream(file);
            clip.open(audio);
        } catch (Exception e) {
           System.out.println(e);
        }
    }
    public void botom(){
        Image img = icon.getImage() ;  
        Image newimg = img.getScaledInstance( 50, 50,  java.awt.Image.SCALE_SMOOTH );  
        icon = new ImageIcon( newimg );
        button1.setIcon(icon);
        button1.setVerticalAlignment(JButton.CENTER);
        button1.addActionListener(this);
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource()== button1  ){
            if(isnotplaying){
                System.out.println("audio is playing");
            clip.setMicrosecondPosition(0);
            clip.start();
            isnotplaying = false;
            
        }else{
       clip.stop();
      isnotplaying = true;
    }}}}


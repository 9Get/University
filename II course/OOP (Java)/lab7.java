import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Main{

    private static void createAndShowGUI() {
        Clinic clinic = new Clinic("Обласна лікарня №16");
        JFrame frame = new JFrame(clinic.getClinicName());
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JLabel label2 = new JLabel("Нова назва лікарні:");
        label2.setFont(new Font("Times New Roman", Font.PLAIN, 14));
        JTextField TFNewClinicName = new JTextField();
        JButton button1 = new JButton("Підтвердити зміну");
        button1.addActionListener( new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                frame.getContentPane().setName(clinic.getClinicName());
            }
        });

        JPanel changeClinicNamePanel = new JPanel( new GridLayout(3, 1) );
        changeClinicNamePanel.add(label2);
        changeClinicNamePanel.add(TFNewClinicName);
        changeClinicNamePanel.add(button1);

        JTextField TFDoctorName = new JTextField();
        JTextField TFDoctorSurname = new JTextField();
        JSpinner SDoctorAge = new JSpinner(new SpinnerNumberModel(1,1,150,1));
        JRadioButton RBMale = new JRadioButton("Male");
        JRadioButton RBFemale = new JRadioButton("Female");
        RBMale.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(RBMale.isSelected()) RBFemale.setSelected(false);
            }
        });
        RBFemale.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(RBFemale.isSelected()) RBMale.setSelected(false);
            }
        });
        JTextField TFDoctorDoB = new JTextField();
        JTextField TFDoctorPhoneNumber = new JTextField();
        JTextField TFDoctorGmail = new JTextField();
        JButton button2 = new JButton("Додати лікаря");

        button2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String sex;
                if(RBMale.isSelected()) sex = RBMale.getText();
                else sex = RBFemale.getText();

                clinic.addDoctor( new Doctor(
                        TFDoctorName.getText(),
                        TFDoctorSurname.getText(),
                        (Integer)SDoctorAge.getValue(),
                        sex,
                        TFDoctorDoB.getText(),
                        TFDoctorPhoneNumber.getText(),
                        TFDoctorGmail.getText()
                ));
                clinic.showListOfDoctors();
            }
        });

        JPanel addDoctorPanel = new JPanel( new GridLayout(8, 2));
        addDoctorPanel.add(new JLabel("Ім'я:"));
        addDoctorPanel.add(TFDoctorName);
        addDoctorPanel.add(new JLabel("Прізвище:"));
        addDoctorPanel.add(TFDoctorSurname);
        addDoctorPanel.add(new JLabel("Вік:"));
        addDoctorPanel.add(SDoctorAge);
        addDoctorPanel.add(RBMale);
        addDoctorPanel.add(RBFemale);
        addDoctorPanel.add(new JLabel("Дата народження:"));
        addDoctorPanel.add(TFDoctorDoB);
        addDoctorPanel.add(new JLabel("Номер телефону:"));
        addDoctorPanel.add(TFDoctorPhoneNumber);
        addDoctorPanel.add(new JLabel("Gmail:"));
        addDoctorPanel.add(TFDoctorGmail);
        addDoctorPanel.add(button2);

        JPanel west = new JPanel(new GridBagLayout());
        GridBagConstraints gbc2 = new GridBagConstraints();
        gbc2.anchor = GridBagConstraints.WEST;
        gbc2.weighty = 1;
        west.add(addDoctorPanel, gbc2);

        JPanel east = new JPanel(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.anchor = GridBagConstraints.EAST;
        gbc.weighty = 1;
        east.add(changeClinicNamePanel, gbc);

        JMenu menu = new JMenu("Menu");
        JMenuBar menuBar = new JMenuBar();
        JMenuItem exitButton = new JMenuItem("Exit");
        exitButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(0);
            }
        });
        menu.add(exitButton);
        menuBar.add(menu);

        frame.setJMenuBar(menuBar);
        frame.add(east, BorderLayout.EAST);
        frame.add(west, BorderLayout.WEST);
        frame.setVisible(true);
        frame.setSize(500,350);
    }
    public static void main(String[] args) {
        Clinic clinic = new Clinic();
        Doctor[] doctors = { new Doctor("Валентин", "Деменков", 84, "Male","15.10.1938",
                "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Володимир", "Литвиненко", 84, "Male", "01.01.1938",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Єкатерина", "Амосова", 66, "Female", "08.02.1956",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Василь", "Пікалюк", 68, "Male", "16.11.1954",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Вадим", "Гордієнко", 92, "Male", "29.10.1930",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Володимир", "Коваленко", 73, "Male", "02.02.1949",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Леся", "Романчук", 67, "Female", "28.07.1955",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com")};

        javax.swing.SwingUtilities.invokeLater(new Runnable() {
            public void run() {
                createAndShowGUI();
            }
        });

        for (int i = 0; i < doctors.length; i++) { clinic.addDoctor(doctors[i]); }


    }
}
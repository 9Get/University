import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

class Doctor{
    private String name;
    private String surname;
    private String dob;
    private String phoneNumber;
    private String gmail;

    public Doctor(String name, String surname, String dob, String phoneNumber, String gmail){
        this.name = name;
        this.surname = surname;
        this.dob = dob;
        this.gmail = gmail;
        this.phoneNumber = phoneNumber;
    }

    public String getName(){ return name; }
    public String getSurname(){ return surname; }
    public String getDob(){ return dob; }
    public String getPhoneNumber(){ return phoneNumber; }
    public String getGmail(){ return gmail; }
}

class DoctorNameComparator implements Comparator<Doctor>{
    @Override
    public int compare(Doctor doc1, Doctor doc2) {
        return doc1.getName().compareTo(doc2.getName());
    }
}

class DoctorSurNameComparator implements Comparator<Doctor>{
    @Override
    public int compare(Doctor doc1, Doctor doc2) {
        return doc1.getSurname().compareTo(doc2.getSurname());
    }
}

class Clinic{
    private final ArrayList<Doctor> doctors = new ArrayList<>();
    private final ArrayList<LocalTime> receptions = new ArrayList<>();

    Comparator<Doctor> docNameComp = new DoctorNameComparator();
    Comparator<Doctor> docSurNameComp = new DoctorSurNameComparator();

    public void addDoctor(Doctor doctor){
        doctors.add(doctor);
    }

    public String findDoctorBySurname(String surname){
        for(int i = 0; i < doctors.toArray().length; i++){
            if(doctors.get(i).getSurname() == surname)
                return "Лікар якого ви шукали: " + getDoctorInfo(i);
        }
        return "Лікаря не знайдено.";
    }

    public void sortDoctorInfoByName(){
        Collections.sort(doctors, docNameComp);
    }

    public void  sortDoctorInfoBySurname(){
        Collections.sort(doctors, docSurNameComp);
    }

    public String getDoctorInfo(int position){
        return "Ім'я: " + doctors.get(position).getName() + ";\tПрізвище: " + doctors.get(position).getSurname() +
                ";\tДата народження: " + doctors.get(position).getDob() + ";\tНомер телефону: " + doctors.get(position).getPhoneNumber()
                + ";\tGmail: " + doctors.get(position).getGmail() + ".\n";
    }

    public void showListOfDoctors(){
        for (int i = 0; i < doctors.size(); i++){ System.out.print(getDoctorInfo(i)); }
    }

    public void printSchedule(){
        for (int i = 0; i < receptions.size(); i++){
            System.out.print(receptions.get(i));
        }
    }

    public void makeAppointment(LocalTime time){
        if((time.isAfter(LocalTime.of(9,0)) && time.isBefore(LocalTime.of(12,0)))
                || (time.isAfter(LocalTime.of(14,0)) && (time.isBefore(LocalTime.of(18,0))))
                && !receptions.contains(time)){
            receptions.add(time);
        } else {
            System.out.print("Ви не можете записатись до лікаря на даний час.");
            printSchedule();
        }
    }
}

public class Main {

    public static void main(String[] args) {
        Clinic clinic = new Clinic();
        Doctor[] doctors = { new Doctor("Валентин", "Деменков", "15.10.1938",
                "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Володимир", "Литвиненко", "01.01.1938",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Єкатерина", "Амосова", "08.02.1956",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Василь", "Пікалюк", "16.11.1954",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Вадим", "Гордієнко", "29.10.1930",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Володимир", "Коваленко", "02.02.1949",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com"),
                new Doctor("Леся", "Романчук", "28.07.1955",
                        "XXX-XXX-XX-XX", "XXXXXXXXXXX@gmail.com")};

        for (int i = 0; i < doctors.length; i++) { clinic.addDoctor(doctors[i]); }
        clinic.showListOfDoctors();

        System.out.print("\n");
        
        System.out.print(clinic.findDoctorBySurname("Пікалюк"));

        System.out.print("\n");

        clinic.sortDoctorInfoByName();
        clinic.showListOfDoctors();

        System.out.print("\n");

        clinic.sortDoctorInfoBySurname();
        clinic.showListOfDoctors();

        System.out.print("\n");

        clinic.makeAppointment(LocalTime.parse("10:30:00"));
    }
}
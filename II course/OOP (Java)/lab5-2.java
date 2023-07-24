import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.ValueSource;
import org.junit.platform.commons.util.StringUtils;

import javax.print.Doc;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

import static org.junit.jupiter.api.Assertions.*;

class ClinicTest {

    static Doctor doctor;
    static ArrayList<Doctor> doctors;

    @BeforeAll
    static void prepareData(){
        doctor = new Doctor("Катерина","Парознюк","067283821","katparoz@gmail.com");
        doctors = new ArrayList<>();
        doctors.add(doctor);
    }

    @Test
    void testAddDoctor() {
        assertEquals(doctor,doctors.get(0));
    }

    @ParameterizedTest
    @ValueSource(strings = {"Парознюк"})
    void testFindDoctorBySurname(String surname) {
        assertEquals(doctors.get(0).getSurname(),surname);
    }

    @Test
    void testSortDoctorInfoSurname() {
        Comparator<Doctor> docSurnameComp = new DoctorSurnameComparator();
        Doctor doctor1 = new Doctor("Анастасия","Анрак","09932122","an_anrak@gmail.com");
        doctors.add(doctor1);
        Collections.sort(doctors,docSurnameComp);
        assertEquals(doctors.get(0),doctor1);
    }

    @Test
    void testGetDoctorInfo() {
        assertEquals(doctors.get(0).getName()+doctors.get(0).getSurname()+doctors.get(0).getPhoneNumber()+doctors.get(0).getGmail(),
                "Катерина"+"Парознюк"+"067283821"+"katparoz@gmail.com");
    }
}
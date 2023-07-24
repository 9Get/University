import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;

import static org.junit.jupiter.api.Assertions.*;

class DoctorTest {

    static Doctor doctor;

    @BeforeAll
    static void prepareData(){
        doctor = new Doctor("Катерина","Парознюк","067283821","katparoz@gmail.com");
    }

    @Test
    void testGetDoctorName() {
        assertEquals("Катерина",doctor.getName());
    }

    @Test
    void testGetDoctorSurname() {
        assertEquals("Парознюк",doctor.getSurname());
    }

    @Test
    void testGetDoctorPhoneNumber() {
        assertEquals("067283821",doctor.getPhoneNumber());
    }

    @Test
    void testGetDoctorGmail() {
        assertEquals("katparoz@gmail.com",doctor.getGmail());
    }
}
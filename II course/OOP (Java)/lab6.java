import java.sql.*;

public class DataAccessObject {
    public static Connection getDBConnection(String dbHost, String dbPort, String dbName, String dbUser, String dbPassword)
            throws SQLException{
        Connection dbConn;
        String connString = "jdbc:mysql://" + dbHost + ":" + dbPort + "/" + dbName;

        dbConn = DriverManager.getConnection(connString, dbUser, dbPassword);

        return dbConn;
    }

    public static void populateTable(Connection conn, Doctor doc) throws SQLException {
        String insert = "INSERT INTO doctors " + "VALUES(" + doc.getName() + ", " + doc.getSurname() + ", " +
                doc.getAge() + ", " + doc.getSex() + ", " +
                doc.getDob() + ", " + doc.getPhoneNumber() + ")";

        try (Statement stmt = conn.createStatement()) {
            stmt.executeUpdate(insert);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void viewTable(Connection con) throws SQLException {
        String query = "select * from doctors";
        try (Statement stmt = con.createStatement()) {
            ResultSet rs = stmt.executeQuery(query);
            while (rs.next()) {
                int doctorID = rs.getInt("id");
                String doctorName = rs.getString("name");
                String doctorSurname = rs.getString("surname");
                int doctorAge = rs.getInt("age");
                String doctorSex = rs.getString("sex");
                String doctorDoB = rs.getString("dob");
                String doctorPN = rs.getString("phone_number");
                System.out.println(doctorID + " " + doctorName + " "
                        + doctorSurname + " " + doctorAge + " "
                        + doctorSex + " " + doctorDoB + " "
                        + doctorPN);
            }
        } catch (SQLException e) { e.printStackTrace(); }
    }
}

public class Main{
    public static void main(String[] args) {
        Connection connection;
        Clinic clinic = new Clinic();
        Doctor[] doctors = { new Doctor("Валентин", "Деменков", 84, "Male","15-10-1938",
                "XXXXXXXXXXX"),
                new Doctor("Володимир", "Литвиненко", 84, "Male", "01-01-1938",
                        "XXXXXXXXXXX"),
                new Doctor("Василь", "Пікалюк", 68, "Male", "16-11-1954",
                        "XXXXXXXXXXX"),
                new Doctor("Єкатерина", "Амосова", 66, "Female", "08-02-1956",
                        "XXXXXXXXXXX"),
                new Doctor("Вадим", "Гордієнко", 92, "Male", "29-10-1930",
                        "XXXXXXXXXXX"),
                new Doctor("Володимир", "Коваленко", 73, "Male", "02-02-1949",
                        "XXX-XXX-XX-XX"),
                new Doctor("Леся", "Романчук", 67, "Female", "28-07-1955",
                        "XXXXXXXXXXX")};
        for (int i = 0; i < doctors.length; i++) { clinic.addDoctor(doctors[i]); }

        try {
            connection = DataAccessObject.getDBConnection("localhost", "3306", "clinic",
                    "root", "root");
            
            //for(int i = 0; i < doctors.length; i++)
            //    DataAccessObject.populateTable(connection, doctors[i]);

            DataAccessObject.viewTable(connection);
        } catch (SQLException e) {
            System.out.print("Error Main");
            e.printStackTrace();
        }
    }
}
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.time.Duration;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

class Clothes {
    Type type;
    float price;
    String size;
    Color color;
    LocalDateTime objectDateTime;

    Clothes(){
        price = 0;
        type = null;
        size = null;
        objectDateTime = LocalDateTime.now();
    }
    Clothes(Type type){
        this.type = type;
        objectDateTime = LocalDateTime.now();
    }
    Clothes(Type type, float price) {
        this.type = type;
        this.price = price;
        objectDateTime = LocalDateTime.now();
    }
    Clothes(Type type, float price, String size){
        this.type = type;
        this.price = price;
        this.size = size;
        objectDateTime = LocalDateTime.now();
    }
    Clothes(Type type, float price, String size, Color color){
        this.type = type;
        this.price = price;
        this.size = size;
        this.color = color;
        objectDateTime = LocalDateTime.now();
    }

    public Type getType(){
        return type;
    }
    public void setType(Type type){
        this.type = type;
    }

    public float getPrice(){
        return price;
    }
    public void setPrice(float price){
        this.price = price;
    }

    public String getSize(){
        return size;
    }
    public void setSize(String size){
        this.size = size;
    }

    public Color getColor() {
        return color;
    }
    public void setColor(Color color){
        this.color = color;
    }

    public void findOutTime(String userDateTime){
        LocalDateTime userLDT = LocalDateTime.parse(userDateTime);
        System.out.println("Time interval: " + Duration.between(objectDateTime, userLDT));
    }

    public static void writeDataToFile(Clothes[] clothesArray, String wayToFile){
        try(FileOutputStream fout = new FileOutputStream(wayToFile, false);)
        {
            byte[] buffer = null;
            for(int i = 0; i < clothesArray.length; i++){
                buffer = clothesArray[i].showInfo().getBytes();

                fout.write(buffer, 0, buffer.length);
            }
        }catch (IOException ex){
            System.out.println(ex.getMessage());
        }
        System.out.println("Data was successfully written to the file!");
    }
    public static void readDataFromFile(String wayToFile){
        try(FileInputStream fin=new FileInputStream(wayToFile))
        {
            byte[] buffer = new byte[fin.available()];

            fin.read(buffer, 0, buffer.length);

            for(int i=0; i < buffer.length; i++){
                System.out.print((char)buffer[i]);
            }
        }
        catch(IOException ex){
            System.out.println(ex.getMessage());
        }
        System.out.println("Data was successfully read from file!");

    }

    public String showInfo(){
        return "Type: " + type + ";\t" + "Color: " + color + ";\t" + "Price: " + price + ";\t" + "Size: " + size + ".\n";
    }
}

enum Type {
    BLOUSE,
    COAT,
    DRESS,
    CARDIGAN,
    GLOVES,
    HAT,
    JACKET,
    JEANS,
    SCARF,
    SHIRT,
    SHORTS,
    SKIRT,
    SOCKS,
    SWEATER,
    TIE,
    TROUSERS,
    TSHIRT,
    OVERCOAT
}
enum Color {
    RED("#FF0000"),
    BLUE("#0000FF"),
    GREEN("#00FF00"),
    BLACK("#000000"),
    WHITE("FFFFFF");

    private String colorCode;
    Color(String color) {colorCode = color;}
    public String getColorCode(){return colorCode;}
}

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Clothes[] clothesArray = {new Clothes(), new Clothes(Type.JACKET),
                new Clothes(Type.JEANS, 5500), new Clothes(Type.TSHIRT, 1300, "XL"),
                new Clothes(Type.CARDIGAN, 2700, "L", Color.BLACK)};

        clothesArray[0].setType(Type.SOCKS);
        clothesArray[1].setPrice(12000);
        clothesArray[0].setSize("M");
        clothesArray[2].setSize("L");
        clothesArray[2].setColor(Color.BLUE);

        for (int i = 0; i < clothesArray.length; i++) {
            System.out.print(clothesArray[i].showInfo());
        }

        System.out.println("Enter your date and time (yyyy-MM-ddTHH:mm:ss): ");
        String userTime = input.next();
        System.out.println("Your date and time: " + userTime);

        clothesArray[0].findOutTime(userTime);

        System.out.println("Enter a way to your file: ");
        String userWay = input.next();

        Clothes.writeDataToFile(clothesArray, userWay);

        Clothes.readDataFromFile(userWay);
    }
}
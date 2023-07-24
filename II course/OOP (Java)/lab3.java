import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.*;

interface Confectionery{
    void showComposition();
    void showFreshness();
    void printInfo();
}

class Cake implements Confectionery, Comparable<Cake>{
    private String type;
    private float price;
    private float weight;
    private LocalDate manufactureDate;
    private String composition;

    DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");

    public Cake(){
        type = "None";
        price = 0;
        weight = 0;
        manufactureDate = null;
        composition = "None";
    }
    public Cake(String type, float price, float weight, String manufactureDate, String composition){
        this.type = type;
        this.price = price;
        this.weight = weight;
        this.manufactureDate = LocalDate.parse(manufactureDate);
        this.composition = composition;
    }

    public static void printCakesWithinPriceRange(ArrayList<Cake> cakes, int low, int high) {
        for (Cake cake : cakes)
            if (low <= cake.getPrice() && cake.getPrice() < high)
                cake.printInfo();
    }
    public static void printCakesWithinWeightRange(ArrayList<Cake> cakes, int low, int high) {
        for(Cake cake : cakes)
            if(low <= cake.getWeight() && cake.getWeight() < high)
                cake.printInfo();
    }

    public static void sortCakeArrayByField(ArrayList<Cake> cakes, String field){
        switch (field) {
            case("Type") : Collections.sort(cakes); break;
            case("Price") : Collections.sort(cakes, new CakePriceComparator()); break;
            case("Weight") : Collections.sort(cakes, new CakeWeightComparator()); break;
        }
    }

    @Override
    public int compareTo(Cake o) {
        return type.compareTo(o.getType());
    }

    public String getType() { return type; }
    public float getPrice(){ return price; }
    public float getWeight(){ return weight; }

    public void showComposition() {
        System.out.println("Composition: " + composition);
    }
    public void showFreshness() {
        System.out.println("Today is " + LocalDate.now() + ", the product was baked on " + manufactureDate + ".");
    }
    public void printInfo(){
        System.out.println("Type: " + type + ", price: " + price + ", weight: " + weight + ", manufactureDate: " + manufactureDate + ", composition: " + composition + ".");
    }
}

class CakePriceComparator implements Comparator<Cake>{
    public int compare(Cake cake1, Cake cake2){
        float price1 = cake1.getPrice();
        float price2 = cake2.getPrice();
        if(price1 < price2) return -1;
        else if (price1 == price2) return 0;
        else return 1;
    }
}
class CakeWeightComparator implements Comparator<Cake>{
    public int compare(Cake cake1, Cake cake2){
        float weight1 = cake1.getWeight();
        float weight2 = cake2.getWeight();
        if(weight1 < weight2) return -1;
        else if (weight1 == weight2) return 0;
        else return 1;
    }
}

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        ArrayList<Cake> cakes = new ArrayList<>();
        cakes.add(new Cake("Mousse cake", 1500, 2, "2022-02-05", "None"));
        cakes.add(new Cake("Classic cake", 1000, 1.5f, "2022-02-07", "None"));
        cakes.add(new Cake());

        showCompositionOf(cakes.get(0));

        Cake.sortCakeArrayByField(cakes, "Type");
        for (Cake cake : cakes){
            cake.printInfo();
        }

        Cake.sortCakeArrayByField(cakes, "Weight");
        for (Cake cake : cakes){
            cake.printInfo();
        }
    }

    public static void showCompositionOf(Confectionery con) {
        con.showComposition();
    }
}
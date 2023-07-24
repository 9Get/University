import java.util.Scanner;

public class Main {
    public void findCommonElements(int[][] array1, int[][] array2){
        for(int i = 0; i < array1.length; i++){
            for(int j = 0; j < array1[i].length; j++){
                for(int k = 0; k < array2.length; k++){
                    for(int l = 0; l < array2[k].length; l++){
                        if(array2[k][l] == array1[i][j]) System.out.print(array2[k][l]);
                    }
                }
            }
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        Main main = new Main();

        int[][] array1 = new int[2][2];
        int[][] array2 = new int[3][3];

        System.out.println("Initialize the first array: ");
        for(int i = 0; i < array1.length; i++){
            for(int j = 0; j < array1[i].length; j++){
                array1[i][j] = in.nextInt();
            }
        }

        System.out.println("Initialize the second array: ");
        for(int i = 0; i < array2.length; i++){
            for(int j = 0; j < array2[i].length; j++){
                array2[i][j] = in.nextInt();
            }
        }

        System.out.print("Common elements: ");
        main.findCommonElements(array1, array2);

        in.close();
    }
}
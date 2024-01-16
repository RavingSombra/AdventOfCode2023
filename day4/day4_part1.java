import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) throws IOException {
        FileReader fr = new FileReader("C:\\Users\\dafm2\\Desktop\\Nova pasta\\input-day4.txt");
        BufferedReader reader = new BufferedReader(fr);
        String line;
        int total = 0;
        
        while((line = reader.readLine()) != null) {
            int idxBar = line.indexOf('|');
            int idxDots = line.indexOf(':');

            ArrayList<Integer> winningNumbers = new ArrayList<>();
            ArrayList<Integer> myNumbers = new ArrayList<>();

            for(int idx = idxDots+2; idx < idxBar-1;idx+=3){
                String temp = line.substring(idx,idx+2).trim();
                winningNumbers.add(Integer.parseInt(temp));
            }

            System.out.println(winningNumbers);

            for(int idx = idxBar+2; idx < line.length()-1;idx+=3){
                String temp = line.substring(idx,idx+2).trim();
                myNumbers.add(Integer.parseInt(temp));
            }

            System.out.println(myNumbers);

            int points = 0;

            for (Integer winningNumber : winningNumbers) {
                if(myNumbers.contains(winningNumber)){
                    if(points == 0){
                        points = 1;
                    }
                    else{
                        points = points * 2;
                    }
                }
            }

            System.out.println("This line points: " + points);
            total += points;
        }

        System.out.println("Total: " + total);
    }
}
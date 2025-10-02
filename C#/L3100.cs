public class Solution {
    int EX ;
    int drunk =0;

    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int currentFull = numBottles;
        int currentEmpty = 0;
        EX = numExchange;

        while(currentFull > 0) {
            currentEmpty = Drink(currentFull, currentEmpty);
            (currentFull, currentEmpty) = Exchange(currentEmpty);
        }
        return drunk;
        
    }
    private int Drink(int full, int empty){
        drunk += full;
        return empty + full;

    }
    private (int,int) Exchange(int empty){
        if(empty >= EX){
            empty -= EX;
            EX++;
            return (1, empty);
        }
        return (0, empty); 
    }
}
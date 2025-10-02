// Time O(n)
// Space O(1)
public class Solution {
    int EX;
    int drunk =0;

    public int NumWaterBottles(int numBottles, int numExchange) {
        EX = numExchange;
        drunk =0;
        int currentFull = numBottles;
        int currentEmpty = 0;
        do {
            currentEmpty += Drink(currentFull);            
            (currentFull, currentEmpty) = Exchange(currentEmpty);
        }
        while(currentFull > 0);
        return drunk;
    }
    private int Drink(int full){
        drunk += full;
        return full;
    }
    private (int,int) Exchange(int empty){
        int fullBottle = empty / EX;
        int remain = empty  % EX;
        return (fullBottle, remain);
    }
}
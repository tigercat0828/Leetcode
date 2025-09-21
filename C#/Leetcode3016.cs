using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Solutions {
    public class Leetcode3016 {

        public int MinimumPushes(string word) {
            Dictionary<char, int> letterToNum = [];                     // record x locate at what number slot
            Dictionary<char, int> letterToPush = [];                      // record x need how many push
            List<List<int>> keyboard = [];   // the description of the phone buttons
            for (int i = 0; i < 10; i++) keyboard.Add([]);
        
            int code = 2;
            foreach (char letter in word) {
                if (!letterToNum.ContainsKey(letter)) {
                    if (code > 9) {
                        code = code % 10 + 2;
                    }
                    letterToNum.Add(letter, code++);
                    int number = letterToNum[letter];
                    keyboard[number].Add(letter);
                    letterToPush.Add(letter, keyboard[number].Count);
                }
            }
            int push = 0;
            foreach (char letter in word) {
                push += letterToPush[letter];
            }
            return push;
        }
    }
}

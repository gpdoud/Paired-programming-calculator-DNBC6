using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary {

    public class CalcLib {

        public static int Add(int total, int amount) {
            return total += amount;
        }
        public static int Subtract(int total, int amount) {
            return total -= amount;
        }
        public static int Multiply(int total, int amount) {
            return total *= amount;
        }
        public static int Divide(int total, int amount) {
            return total /= amount;
        }
        public static int Clear() {
            return 0;
        }
        public CalcLib() {
        }
    }
}

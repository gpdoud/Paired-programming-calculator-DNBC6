using System;

namespace PairedProgrammingCalculatorProject {
    class Program {

        static void Main(string[] args) {
            var total = 0;
            while(true) {
                var ans = Prompt(total);
                if(ans[0].ToLower().Contains("end")) {
                    break;
                }
                var nbr = 0;
                if(ans.Length > 1) {
                    var success = int.TryParse(ans[1], out nbr);
                    if(!success) throw new Exception("Parm is not a number.");
                }
                switch(ans[0].ToLower()) {
                    case "add":         total = CalculatorLibrary.CalcLib.Add(total, nbr);          break;
                    case "subtract":    total = CalculatorLibrary.CalcLib.Subtract(total, nbr);     break;
                    case "multiply":    total = CalculatorLibrary.CalcLib.Multiply(total, nbr);     break;
                    case "divide":      total = CalculatorLibrary.CalcLib.Divide(total, nbr);       break;
                    case "clear":       total = CalculatorLibrary.CalcLib.Clear();                  break;
                }
            }
        }
        static string[] Prompt(int total) {
            Console.WriteLine($"< total {total}");
            Console.Write("> ");
            var resp = Console.ReadLine();
            return resp.Split(' ');
        }
    }
}

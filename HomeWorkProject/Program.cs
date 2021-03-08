using System;

namespace HomeWorkProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            var testTest = "tester";
            Console.WriteLine(testTest);
            var dogName = "Willow";
            var catName = "tigger";
            var housePets = dogName + " " + catName;
            Console.WriteLine(housePets);
            housePets = $" the dogs name is {dogName} the cats name is {catName}";
            Console.WriteLine(housePets);

            var topFiveStrengths = new string[5];
                    topFiveStrengths[0] = "Deliberative";
                    topFiveStrengths[1] = "Context";
                    topFiveStrengths[2] = "Analytical";
                    topFiveStrengths[3] = "Harmony";
                    topFiveStrengths[4] = "Adaptability";
            Console.WriteLine(topFiveStrengths[1]);

        }
    }
}

namespace Exc2{
    class Program{
        public static void Main(string[] args){
            const int students = 10;
            int[] grades = new int[101];

            for(int i = 0; i < students; i++){
                Console.Write("Enter a grade: ");
                int grade = int.Parse(Console.ReadLine());
                grades[grade]++;
            }

            for(int i = grades.Length-1; i >= 0; i--){
                Console.WriteLine($"Grade: {i}, Amount: {grades[i]}");
            }

            int[] gradesInRange = new int[10];
            for(int i = 0; i < 100; i+=10){
                //Console.WriteLine($"[{i}, {i+9}]");
                int sum = 0;
                for(int j = i; j <= ((i==90) ? i+10 : i+9); j++){
                    sum += grades[j];
                }
                gradesInRange[i/10] = sum;
            }

            int maxAmount = 0;
            for(int i = 0; i < 10; i++){
                if(gradesInRange[i] > maxAmount){
                    maxAmount = gradesInRange[i];
                }
            }

            for(int i = 0; i < 10; i++){
                if(gradesInRange[i] == maxAmount){
                    int rangeTop = (i == 9) ? 100 : (i*10+9);
                    Console.WriteLine($"Most Common Range: {i*10}-{rangeTop}");
                }
            }
        }
    }
}
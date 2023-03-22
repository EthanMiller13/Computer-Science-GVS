namespace Exc4{
    class Program {
        public static void Main (string[] args) {
            //Exc D
            Console.Write("Enter the number of students: ");
            int students = int.Parse(Console.ReadLine());
            int[] grades = SetGrades(students);
            Factor(ref grades);
            PrintGrades(grades);
        }

        //Exc A
        public static void Factor(ref int[] grades){
            for(int i = 0; i < grades.Length; i++){
                int newGrade = (int)(grades[i] * 1.1);
                grades[i] = (newGrade > 100) ? 100 : newGrade;
            }
        }

        //Exc B
        public static int[] SetGrades(int students){
            int[] grades = new int[students];
            for(int i = 0; i < students; i++){
                Console.Write($"Enter grade fo student No. {i+1}/{students}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            return grades;
        }

        //Exc C
        public static void PrintGrades(int[] grades){
            Console.WriteLine("The factored grades are: ");
            for(int i = 0; i < grades.Length; i++){
                Console.Write(grades[i] + "\t");
            }
        }
    }
}
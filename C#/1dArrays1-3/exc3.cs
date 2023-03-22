namespace Exc3{
    class Program {
        public static void Main (string[] args) {
            const int n = 8;
            int[] a = new int[n];
            for(int i = 0; i < n; i++){
                Console.Write($"Enter int No. {i+1}/{n}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++){
                for(int j = 0; j < n; j++){
                    if(a[i] + a[j] == num || a[i] * a[j] == num){
                        Console.WriteLine($"({a[i]}, {a[j]})");
                    }
                }
            }
        }
    }
}
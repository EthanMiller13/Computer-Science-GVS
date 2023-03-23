namespace Exc1{
    class Program {
        public static void Main (string[] args) {
            const int TOP = 8;
            int[] a = new int[TOP];
            for(int i = 0; i < TOP; i++){
                Console.Write($"Enter int No. {i+1}/{TOP}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            int temp = a[TOP-1];
            for (int i = TOP-1; i>0; i--){
                a[i] = a[i-1];
            }
            a[0] = temp;
            
            for(int i = 0; i < TOP; i++){
                Console.Write(a[i] + "\t");
            }
        }
    }
}
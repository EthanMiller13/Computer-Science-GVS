namespace Exc2{
    class Program {
        public static void Main (string[] args) {
            int sumEven = 0;
            int sumOdd = 0;
            //int[] a = {1,2,3,4,5,3}; //True
            int[] a = {5,1,2,4,9,3}; //False

            Console.Write("[a]: \t");
            for(int i = 0; i < a.Length; i++){
                Console.Write(a[i] + "\t");
            }

            for(int i = 0; i<a.Length; i++){
                if(i%2 == 0){
                    sumOdd += a[i];
                }else{
                    sumEven += a[i];
                }
            }
            Console.WriteLine("\nSumOfOddIndexes is equal to SumOfEvenIndexes? " + (sumOdd == sumEven));
        }
    }
}
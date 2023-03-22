namespace Exc2{
    class Program {
        public static void Main (string[] args) {
            int sumEven = 0;
            int sumOdd = 0;
            int[] a = {1,2,3,4,5,3};

            for(int i = 0; i<a.Length; i++){
                if(i%2 == 0){
                    sumOdd += a[i];
                }else{
                    sumEven += a[i];
                }
            }
            Console.WriteLine("SumOfOddIndexes is equal to SumOfEvenIndexes? " + (sumOdd == sumEven));
        }
    }
}
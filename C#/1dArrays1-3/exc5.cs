namespace Exc5{
    class Program {
        public static void Main (string[] args) {
            int[] arr = {2, 3, 4, 4, 4, 5, 5, 6, 2, 1, 1, 1, 1, 5, 4};
            Console.WriteLine(LongestSequence(arr));
        }

        public static int LongestSequence(int[] arr){
            int currentSeq = 1;
            int maxSeq = 0;
            for(int i = 1; i < arr.Length; i++){
                if(arr[i] == arr[i-1]){
                    currentSeq++;
                }else{
                    if(currentSeq > maxSeq){
                        maxSeq = currentSeq;
                    }
                    currentSeq = 1;
                }
            }

            return maxSeq;
        }
    }
}
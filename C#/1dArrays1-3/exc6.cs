namespace Exc6{
    class Program {
        public static void Main (string[] args) {
            int[] mArr = {9, 2, 0, -1, 3, 11, 23};
            int[] kArr = {1, -4, 4, 9, 2};
            int[] newArr = Multiply(mArr, kArr);

            for (int i = 0; i < newArr.Length; i++){
                Console.Write($"{newArr[i]}, ");
            }
        }

        public static int[] Multiply(int[] mSized, int[] kSized){
            int[] multipliedArr = new int[mSized.Length];

            for(int i = 0; i < kSized.Length; i++){
                multipliedArr[i] = mSized[i] * kSized[i];
            }

            for(int j = kSized.Length; j < mSized.Length; j++){
                multipliedArr[j] = mSized[j];
            }

            return multipliedArr;
        }
    }
}
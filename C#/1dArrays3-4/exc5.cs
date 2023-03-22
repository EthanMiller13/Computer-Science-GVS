namespace Exc5{
    class Program{
        public static void Main(string[] args){
            int[] arr = {6, 9, 2, 2, 9, 4, -3};
            int num = 9;
            int[] filteredArray = Filter(arr, num);
            
            for(int i = 0; i < filteredArray.Length; i++){
                Console.Write($"{filteredArray[i]}, ");
            }
        }

        public static int[] Filter(int[] arr, int num){
            int aSize = arr.Length;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] == num){
                    aSize--;
                }
            }
            int[] filteredArray = new int[aSize];
            int index = 0;
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i] != num);
                if(arr[i] != num){
                    filteredArray[index] = arr[i];
                    index++;
                }
            }
            return filteredArray;
        }
    }
}
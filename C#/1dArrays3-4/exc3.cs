namespace Exc3{
    class Program{
        public static void Main(string[] args){
            int[] array1 = new int[9];
            int[] array2 = new int[4];

            for (int i = 0; i < array1.Length; i++){
                Console.Write($"Enter int No. {i+1}/{array1.Length} for array1: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++){
                Console.Write($"Enter int No. {i+1}/{array2.Length} for array2: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int newArraySize = 0;
            for(int i = 0; i < array1.Length; i++){
                for(int j = 0; j < array2.Length; j++){
                    if(array1[i] == array2[j]){
                        newArraySize++;
                    }
                }
            }

            int[] sharedValuesArray = new int[newArraySize];
            int sharedIndex = 0;
            for(int i = 0; i < array1.Length; i++){
                for(int j = 0; j < array2.Length; j++){
                    if(array1[i] == array2[j]){
                        sharedValuesArray[sharedIndex] = array1[i];
                        sharedIndex++;
                    }
                }
            }

            Console.Write("Shared values: ");
            for(int i = 0; i < newArraySize; i++){
                Console.Write($"{sharedValuesArray[i]}\t");
            }
            
        }
    }
}
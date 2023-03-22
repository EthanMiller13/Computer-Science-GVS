namespace Exc4{
    class Program{
        public static void Main(string[] args){
            const int size = 15;
            char[] last = new char[size];
            char[] oneBeforeLast = new char[size];

            for (int i = 0; i < last.Length; i++){
                Console.Write($"Enter boat No. {i+1}/{size} [last]: ");
                last[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < oneBeforeLast.Length; i++){
                Console.Write($"Enter boat No. {i+1}/{size} [oneBeforeLast]: ");
                oneBeforeLast[i] = char.Parse(Console.ReadLine());
            }


            int sharedSize = 0;
            for (int i = 0; i < last.Length; i++){
               for (int j = 0; j < oneBeforeLast.Length; j++){
                    if(last[i] == oneBeforeLast[j]){
                        sharedSize++;
                    }
                } 
            }
            int notSharedSize = 26 - sharedSize;

            char[] remainingBoats = new char[notSharedSize];
            int remIndex = 0;
            for (int i = 97; i < 123; i++){
                bool inBoth = false;
                for(int j = 0; j < last.Length; j++){
                    if(last[j] == (char)i){
                        for(int k = 0; k < oneBeforeLast.Length; k++){
                            if(oneBeforeLast[k] == (char)i){
                                inBoth = true;
                                break;
                            }
                        }
                        if(inBoth){
                            break;
                        }
                    }
                }
                if(inBoth == false){
                    remainingBoats[remIndex] = (char)i;
                    remIndex++;
                }
            }

            Console.WriteLine($"{notSharedSize} are remained.");
            Console.WriteLine("remainingBoats: ");
            for(int i = 0; i < remainingBoats.Length; i++){
                Console.Write(remainingBoats[i] + ", ");
            }

        }
    }
}
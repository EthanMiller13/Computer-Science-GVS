namespace Exc1{
    class Program{
        public static void Main(string[] args){
            int[] plays = new int[15];

            while(true){
                Console.WriteLine("Enter 0 to exit.");
                Console.WriteLine("Enter a play number[1-15]: ");
                int playNum = int.Parse(Console.ReadLine());

                if(playNum == 0){
                    break;
                }else{
                    Console.WriteLine($"Enter number of tickets for play {playNum}: ");
                    int tickets = int.Parse(Console.ReadLine());
                    plays[playNum-1] += tickets;
                }
            }

            int maxTicktes = 0;
            for(int i = 0; i < plays.Length; i++){
                Console.WriteLine($"Play: {i+1}, Ticktets: {plays[i]}");
                if(plays[i] > maxTicktes){
                    maxTicktes = plays[i];
                }
            }

            for(int i = 0; i < plays.Length; i++){
                if(plays[i] == maxTicktes){
                    Console.WriteLine($"Play {i+1} is a popular play.");
                }
            }
        }
    }
}
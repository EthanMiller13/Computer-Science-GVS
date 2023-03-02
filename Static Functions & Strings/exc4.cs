namespace Exc4{
    class Program{
        public static void Main(string[] args){
            bool valid = false;
            while (valid is false){
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();
                bool hasDigit = false, hasLetter = false;
                if (password.Length >=6){
                    for(int i = 0; i < password.Length; i++){
                        bool hasUpper = (65 <= password[i] && password[i] <= 90);
                        bool hasLower = (97 <= password[i] && password[i] <= 122);
                        hasLetter = ((hasUpper || hasLower) || hasLetter is true);
                        hasDigit = ((48 <= password[i] && password[i] <= 57) || hasDigit is true);
                        //Console.WriteLine($"letter? {hasLetter}, digit? {hasDigit}");
                        if(hasLetter && hasDigit){
                            valid = true;
                            break;
                        }
                    }
                    if(valid is false){
                        Console.WriteLine("Invalid password!");
                    }  
                }else{
                    Console.WriteLine("Invalid password!");
                }
            }
            Console.WriteLine("Logged in!");
        }
    }
}
//start main here
int userChoice = GetUserChoice(); 

while(userChoice != 3){
    Route(userChoice);
    userChoice = GetUserChoice();
}

//end main

static int GetUserChoice(){
    DisplayMenu(); 
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if (userChoice == "1" || userChoice == "2" || userChoice == "3") {
        return true;
    }
    return false;
}

static void Route(int userChoice) {
    if (userChoice == 1) {
        GetFull();
    }
    else if (userChoice == 2){
        GetPartial();
    }
    else if (userChoice != 3)
        SayInvalid();
        PauseAction();
}

static void GetFull(){
    Console.Clear();
    Random rnd = new Random();
    int number = rnd.Next(3, 10);
    for (int i=0; i < number; i++){
        for (int j=0; j <= i; j++){
            Console.Write("o ");
        }
        Console.WriteLine();
    }
}

static void GetPartial(){
    Console.Clear();
    Random rnd = new Random();
    int number = rnd.Next(3, 10);
    Console.WriteLine("o"); //I'm hardcoding this for aesthetic purposes
    for (int i=1; i < number; i++){
        for (int j=0; j<= i; j++){
            Random rand = new Random();
            int rNumber = rand.Next(100);
            if (rNumber > 75){
                Console.Write("  ");
            }
            else {
                Console.Write("o ");
            }
        }
        Console.WriteLine();
    }
}

static void SayInvalid(){
    Console.WriteLine("Invalid. Please enter \"1\", \"2\", or \"3\"");
}

static void PauseAction(){
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}
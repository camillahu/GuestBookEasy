
using Gjestebok;


Book currentBook = new Book(DateTime.Now.ToString("dd/MM/YYY"));
bool mainMenuRunning = true; 

MainMenu();
void MainMenu()
{
    Console.WriteLine($"Welcome to today's book ({currentBook.DateString})");

    while (mainMenuRunning)
    {
        Console.WriteLine();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Add new party \n2. Search for party \n3. See all parties \n4. See all parties with names");
        mainMenuRunning = false;
        ChooseOption();
        Console.WriteLine();
    }
    
}

void ChooseOption()
{
    string menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            currentBook.AddParty(AddNewPartyUI());
            mainMenuRunning = true;
            break;
        case "2":
            currentBook.FindParty();
            mainMenuRunning = true;
            break;
        case "3": currentBook.PrintBookList();
            mainMenuRunning = true;
            break;
        case "4": currentBook.PrintDetailedBookList();
            mainMenuRunning = true;
            break;
        default: Environment.Exit(1);
            break;
    }
}

Party AddNewPartyUI()
{
    
    Console.WriteLine("Type in the full name of the person Responsible for the party.");
    string resName = Console.ReadLine();
    Party newParty = new Party(resName);
    bool adding = AddingGuestsUIChoice();

    while (adding)
    {
        newParty.AddGuest(AddNewGuestUI());
        adding = AddingGuestsUIChoice();
    }
    return newParty;
};

Guest AddNewGuestUI()
{
    Console.Write("Full name:");
    string name = Console.ReadLine();
    Guest newGuest = new Guest(name);
    return newGuest;
}

bool AddingGuestsUIChoice()
{
    Console.WriteLine("Type 1 to add new guest, type anything else to quit making party.");
    string answer = Console.ReadLine();

    return answer == "1";
}
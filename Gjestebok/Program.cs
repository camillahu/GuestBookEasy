
using Gjestebok;

Book currentBook = new Book(DateTime.Now.ToString("dd/MM/YYY"));
bool mainMenuRunning = true; 

MainMenu();
void MainMenu()
{
    $"Welcome to today's book ({currentBook.DateString})".PrintStringToConsole();

    while (mainMenuRunning)
    {
        "".PrintStringToConsole();
        mainMenuRunning = false;
        ChooseOption();
        "".PrintStringToConsole();
    }
}

void ChooseOption()
{
    
    "1. Add new party \n2. Search for party \n3. See all parties \n4. See all parties with names".PrintStringToConsole();
    string menuChoice = "Choose an option:".RequestUIString();
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
    "Type in the name of the person Responsible for the party.".PrintStringToConsole();
    string resName = "Full Name:".RequestUIString();
    Party newParty = new Party(resName);
    bool adding = AddingGuestsUIChoice();

    while (adding)
    {
        newParty.AddGuest(AddNewGuestUI());
        adding = AddingGuestsUIChoice();
    }
    return newParty;  //Denne er bugga nå, jobb her neste gang! 
};

Guest AddNewGuestUI()
{
    string name = "Full name:".RequestUIString();
    Guest newGuest = new Guest(name);
    return newGuest;
}

bool AddingGuestsUIChoice()
{
    string answer = "Type 1 to add new guest, type anything else to quit making party: ".RequestUIString();

    return answer == "1";
}
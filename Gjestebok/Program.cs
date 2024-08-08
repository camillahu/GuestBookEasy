
using Gjestebok;


Book currentBook = new Book(DateTime.Now.ToString("dd/MM/YYY"));

MainMenu();
void MainMenu()
{
    Console.WriteLine($"Welcome to today's book ({currentBook.DateString})");
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add new party \n2. Search for party \n3. See all parties \n4. See all parties with names");
    ChooseOption();
}

void ChooseOption()
{
    string menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            currentBook.AddParty(AddNewPartyUI());
            
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
    return new Guest(name);
}

bool AddingGuestsUIChoice()
{
    Console.WriteLine("Type 1 to add new guest, type anything else to quit making party.");
    string answer = Console.ReadLine();

    return answer == "1";
}
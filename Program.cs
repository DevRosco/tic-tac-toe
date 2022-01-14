
// this is new commnet in new branch
//using vs with github

string userInput;
char input;
char player = 'O';
bool switchPlayers = true;

bool oneTaken = true;
bool twoTaken = true;
bool threeTaken = true;
bool fourTaken = true;
bool fiveTaken = true;
bool sixTaken = true;
bool sevenTaken = true;
bool eightTaken = true;
bool nineTaken = true;

char[,] fields =
{
    {'1','2', '3'},
    {'4', '5', '6'},
    {'7', '8', '9'}
};
 
    void resetFields()
{
    fields[0, 0] = '1';
    fields[0, 1] = '2';
    fields[0, 2] = '3';
    fields[1, 0] = '4';
    fields[1, 1] = '5';
    fields[1, 2] = '6';
    fields[2, 0] = '7';
    fields[2, 1] = '8';
    fields[2, 2] = '9';

    oneTaken = twoTaken = threeTaken = fourTaken = fiveTaken = sixTaken = sevenTaken = eightTaken = nineTaken = true;
}


void switching()
{
   player = switchPlayers ? 'O' : 'X';  
}

void getPlayerInfo()
{
    if (player == 'O')
    {
        Console.WriteLine("Player 1: ");
    }
    else if (player == 'X')
    {
        
        Console.WriteLine("Player 2: ");
    }
}

void checkIfFieldFull()
{
    if(!oneTaken && !twoTaken && !threeTaken && !fourTaken && !fiveTaken && !sixTaken && !sevenTaken && !eightTaken && !nineTaken)
    {
        oneTaken = twoTaken = threeTaken = fourTaken = fiveTaken = sixTaken = sevenTaken = eightTaken = nineTaken = true;
        Console.WriteLine("All fields are taken reset the game");
        Console.WriteLine("pres any key to reset game");
        Console.Read();
        resetFields();
        Console.ReadLine();
        Console.Clear();
        getPlayerInfo();
        getFields();
     }
}

getPlayerInfo();
switching();
getFields();
getInput();

  void getFields()
{
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[0,0], fields[0, 1], fields[0, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[1, 0], fields[1, 1], fields[1, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[2, 0], fields[2, 1], fields[2, 2]);
    Console.WriteLine("     |     |     ");

}

//wining combinations
void checkForWinner()
{
    ///winnig combinations for X
    // -------------
    bool winX1 = fields[0, 0] == 'X' && fields[0, 1] == 'X' && fields[0, 2] == 'X';
    bool winX2 = fields[1, 0] == 'X' && fields[1, 1] == 'X' && fields[1, 2] == 'X';
    bool winX3 = fields[2, 0] == 'X' && fields[2, 1] == 'X' && fields[2, 2] == 'X';
    // |||||||||||||||
    bool winX4 = fields[0, 0] == 'X' && fields[1, 0] == 'X' && fields[2, 0] == 'X';
    bool winX5 = fields[0, 1] == 'X' && fields[1, 1] == 'X' && fields[2, 1] == 'X';
    bool winX6 = fields[0, 2] == 'X' && fields[1, 2] == 'X' && fields[2, 2] == 'X';
    //   \\\\\\\////////
    bool winX7 = fields[0, 0] == 'X' && fields[1, 1] == 'X' && fields[2, 2] == 'X';
    bool winX8 = fields[2, 0] == 'X' && fields[1, 1] == 'X' && fields[0, 2] == 'X';

    ///winnig combinations for O
    // -------------
    bool winO1 = fields[0, 0] == 'O' && fields[0, 1] == 'O' && fields[0, 2] == 'O';
    bool winO2 = fields[1, 0] == 'O' && fields[1, 1] == 'O' && fields[1, 2] == 'O';
    bool winO3 = fields[2, 0] == 'O' && fields[2, 1] == 'O' && fields[2, 2] == 'O';
    // |||||||||||||||
    bool winO4 = fields[0, 0] == 'O' && fields[1, 0] == 'O' && fields[2, 0] == 'O';
    bool winO5 = fields[0, 1] == 'O' && fields[1, 1] == 'O' && fields[2, 1] == 'O';
    bool winO6 = fields[0, 2] == 'O' && fields[1, 2] == 'O' && fields[2, 2] == 'O';
    //   \\\\\\\////////
    bool winO7 = fields[0, 0] == 'O' && fields[1, 1] == 'O' && fields[2, 2] == 'O';
    bool winO8 = fields[2, 0] == 'O' && fields[1, 1] == 'O' && fields[0, 2] == 'O';


    if (winX1 || winX2 || winX3 || winX4 || winX5 || winX6 || winX7 || winX8)
{
    Console.WriteLine("Player two X WIN!!!");
        resetFields();
        Console.ReadLine();
        Console.Clear();
        getPlayerInfo();
        getFields();
    }
    else if (winO1 || winO2 || winO3 || winO4 || winO5 || winO6 || winO7 || winO8)
    {
        Console.WriteLine("Player one O WIN!!!");
        resetFields();
        Console.ReadLine();
        Console.Clear();
        getPlayerInfo();
        getFields();
    } else
    {
        Console.WriteLine("No winner yet!");
    }
}

void taken()
{
    Console.WriteLine("This option is taken take new one");
    getInput();
}

void getInput()
{
    userInput = Console.ReadLine();
    bool test = char.TryParse(userInput, out input);
    

    if (test)
    {
        switch (input)
        {
            case '1':
                if (oneTaken) {
                    fields[0, 0] = player;
                    oneTaken = false;
                    switchPlayers = !switchPlayers;
                } else
                {
                    taken();
                }
                break;
              
            case '2':
                if (twoTaken)
                {
                    fields[0, 1] = player;
                    twoTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '3':
                if (threeTaken)
                {
                    fields[0, 2] = player;
                    threeTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '4':
                if (fourTaken)
                {
                    fields[1, 0] = player;
                    fourTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '5':
                if (fiveTaken)
                {
                    fields[1, 1] = player;
                    fiveTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '6':
                if (sixTaken)
                {
                    fields[1, 2] = player;
                    sixTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '7':
                if (sevenTaken)
                {
                    fields[2, 0] = player;
                    sevenTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '8':
                if (eightTaken)
                {
                    fields[2, 1] = player;
                    eightTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
            case '9':
                if (nineTaken)
                {
                    fields[2, 2] = player;
                    nineTaken = false;
                    switchPlayers = !switchPlayers;
                }
                else
                {
                    taken();
                }
                break;
                
        }
      
        switching();
        Console.Clear();
        getPlayerInfo();
        getFields();
        checkForWinner();
        checkIfFieldFull();

    }
    else
    {
        Console.WriteLine("Please use only number 1-9 and press enter");
        getInput();
        Console.Clear();
        getPlayerInfo();
        getFields();
    }
    getInput();
}






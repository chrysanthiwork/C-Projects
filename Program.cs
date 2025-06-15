Console.WriteLine("Hello!");

var acceptedChars = new List<char>() {
    'S','s','A','a','R','r','E','e'
};

List<string> usersToDos = new List<string>();
char userInput;
string user_todo_description;
string input;

do {
    menu();
    input = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(input) || !checkIfCharIsInAcceptedList(input[0], acceptedChars))
    {
        Console.WriteLine("Invalid Choice");
        menu();
        input = Console.ReadLine();
    }
    userInput = input[0];
    userCommandExecute(userInput);
} while(!(userInput == 'E' || userInput == 'e'));

//Console.ReadKey();

bool checkIfCharIsInAcceptedList(char userInput,List<char> acceptedChars){
    if (!acceptedChars.Contains(userInput)) {
        return false;
    }
    return true;
}

void menu() {
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void printAllUserTodoList()
{
    if (usersToDos.Count == 0)
    {
        Console.WriteLine("You have no any ToDo, to show");
    }
    else
    {
        int count = 0;
        foreach (var todo in usersToDos)
        {
            Console.WriteLine(count + ". " + todo);
            count++;
        }
    }
}
void userCommandExecute(char userInput)
{
    if (userInput == 'S' || userInput == 's')
    {
        printAllUserTodoList();
    }
    else if (userInput == 'A' || userInput == 'a')
    {
        Console.WriteLine("Enter the TODO description");
        user_todo_description = Console.ReadLine();
        bool alreadyExists = usersToDos.Any(todo =>
    todo.Equals(user_todo_description, StringComparison.OrdinalIgnoreCase));
        if (alreadyExists)
        {
            Console.WriteLine("The description must be unique");
        }
        else
        {
            usersToDos.Add(user_todo_description);
        }
    }
    else if (userInput == 'R' || userInput == 'r')
    {
        if(usersToDos.Count > 0)
        {
            printAllUserTodoList();
            char userRemovedToDoIndex = Console.ReadLine()[0];

            if (int.TryParse(userRemovedToDoIndex.ToString(), out int removedIndexToInt))
            {
                if (removedIndexToInt < usersToDos.Count)
                {
                    usersToDos.RemoveAt(removedIndexToInt);
                }
                else
                {
                    Console.WriteLine("The given index is not valid");
                }
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }

        }
        else
        {
            Console.WriteLine("Your TODO list is empty");
        }
    }
}


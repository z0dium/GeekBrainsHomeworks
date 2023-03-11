// Игра жизнь
Console.Clear();
int m = 30;
int n = 30;
int k = 1000;
//bool[,] initialUniverse = {{false,false,false,false,false,false,false,false,false,false},    //    650 iteration life
//                    {false,false,false,false,false,false,false,false,false,false},
//                    {false,false,false,false,true,false,false,false,false,false},
//                    {false,false,false,false,true,false,false,false,false,false},
//                    {false,false,false,false,true,false,false,false,false,false},
//                    {false,false,false,false,false,false,false,true,false,false},
//                    {false,false,false,false,false,false,false,false,true,false},
//                    {false,false,false,false,false,false,false,true,true,true},
//                    {false,false,false,false,false,false,false,false,true,false},
//                    {false,false,false,false,false,false,false,false,false,false}};
//bool[,] initialUniverse = {{false,false,false,false,false,false,false,false,false,false},  //  forever (dynamic loop)
//                    {false,false,false,false,false,false,false,false,false,false},
//                    {false,false,false,false,false,false,false,false,false,false},
//                    {false,false,false,true,true,true,false,false,false,false},
//                    {false,false,false,false,false,false,false,false,false,false},
//                    {false,false,false,false,false,false,false,true,false,false},
//                    {false,false,false,false,false,false,false,false,true,false},
//                    {false,false,false,false,false,false,false,true,true,true},
//                    {false,false,false,false,false,false,false,false,true,false},
//                    {false,false,false,false,false,false,false,false,false,false}};
bool[,] initialUniverse = loadUniverseFromFile();
printUniverse(initialUniverse);
System.Threading.Thread.Sleep(2000);
bool[,] universe = createUniverse(initialUniverse);

executeGame(k);

bool[,] loadUniverseFromFile(){
    Console.Clear();
    try
    {
        using (var sr = new StreamReader("INPUT.TXT"))
        {   
            string inputLine = sr.ReadLine();
            bool[,] result = new bool[inputLine.Length,inputLine.Length];
            for (int i=0; i < inputLine.Length; i++){
                for (int j=0; j < inputLine.Length; j++){
                    result[i,j] = inputLine[j] == 'X' ? true : false;
                }
            inputLine = sr.ReadLine(); 
            if (inputLine == null) break;   
            }
            return result;
        }
        
    }
    catch (IOException e)
    {
        Console.WriteLine("The file could not be read:");
        Console.WriteLine(e.Message);
        return new bool[10,10];
    }
      
}

bool[,] createUniverse(bool[,] initialUniverse){
    bool[,] universe = new bool[m,n];
    Console.Clear();
    Console.WriteLine("Initial state");
    for (int i=0; i < initialUniverse.GetLength(0); i++){
        Console.Write("|");
        for (int j=0; j < initialUniverse.GetLength(1); j++){
            universe[i+initialUniverse.GetLength(0),j+initialUniverse.GetLength(1)] = initialUniverse[i,j];
            Console.Write(initialUniverse[i,j] ? "X" : " ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
    return universe;
}
void iterateAndPrintUniverse(bool[,] universe){
    bool[,] currentState = (bool[,])universe.Clone();
    for (int i=0; i < currentState.GetLength(0); i++){
        Console.Write("|");
        for (int j=0; j < currentState.GetLength(1); j++){
            int aliveNeighbour = 0;
            for (int z = -1; z < 2; z++){
                for (int y = -1; y < 2 ; y++) {
                    if (y != 0 || z != 0 ){
                        if (currentState[((n - 1) + i + z) % (n-1),((m - 1) + j + y) % (m-1)] == true) aliveNeighbour = aliveNeighbour + 1;
                    }
                }
            }
            if (aliveNeighbour == 2) {}
            else if (aliveNeighbour == 3) universe[i,j] = true;
            else universe[i,j] = false;
            Console.Write(universe[i,j] ? "X" : " ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}
void executeGame(int countOfGeneration){
    for (int i=0; i < countOfGeneration; i++){
        Console.Clear();
        Console.WriteLine($"Generation {i}");
        iterateAndPrintUniverse(universe);
        System.Threading.Thread.Sleep(100);
    }
}

void printUniverse(bool[,] universe){
    Console.Clear();
    for (int i = 0; i < universe.GetLength(0); i++){
        for (int j =0; j < universe.GetLength(1); j++){
            Console.Write(universe[i,j] ? 'X' : ' ');
        }
        Console.WriteLine();
    }
}


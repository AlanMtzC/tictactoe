class program
{
    static int MATRIX_SIZE = 3;
    //y,x
    static char[,] matrix = new char[MATRIX_SIZE, MATRIX_SIZE];
    static void Main(string[] args)
    {
        string Line = "";
        for (int y = 0; y < MATRIX_SIZE; y++)
        {
            Line += matrix[y, x] + "|";
        }
        Line = Line.Substring(0, Line.Length - 1);
        Console.WriteLine(Line);
        Console.WriteLine("-----");
    }
}
static void ImputRequest()
{
    Console.WriteLine("Ingresa las coordenadas de la forma y,x en donde quieres hacer el movimiento y presiona enter");
    string userInputCoordinates = Console.ReadLine();
    //quitar espacios
    userInputCoordinates = userInputCoordinates.Replace("", "");
    //separar en arreglo de valores
    string[] coordenadas = userInputCoordinates.split(",");
    //convertit en coordenadas tipo entero
    int y = Convert.ToInt32(coordenadas[0]);
    int x = Convert.ToInt32(coordenadas[1]);
    AddValue('X', y, x);
}
static bool checkThreeLines()
{
    //filas
    //matrix[0, 0]
    //matrix[0, 1]
    //matrix[0, 2]
    for (int y = 0; y < 3; y++)
    {
        char value = ' ';
        bool sameValue = true;
        for (int x = 0; x < 3; x++)
        {
            if (x == 0) 
            {
                value = matrix[y, x];
            } else
            {
                sameValue = sameValue && (value == matrix[y, x]);
            }
        }
        if (sameValue && value != ' ')
        {
            return true;
        }
        //columnas
        for (int x = 0; x < 3; x++)
    {
        char value = ' ';
        bool sameValue = true;
        for (int y = 0; y < 3; y++)
        {
            if (x == 0) 
            {
                value = matrix[y, x];
            } else
            {
                sameValue = sameValue && (value == matrix[y, x]);
            }
        }
        if (sameValue && value != ' ')
        {
            return true;
        }
        //diagonales
        return false;
    }
    static void AIrequest()
    {
        Random r = new Random();
        Math.Floor(r.NextDouble() * 3);
    }
    static void Main(string[] args);
    {
        //PrintMatrix();
        //InputRequest();
        //PrintMatrix();
        bool gameEnded = false;
        int turns = 0;
        while (!gameEnded)
        {
            ImputRequest();
            turns++;
            gameEnded = checkThreeLines();
            if (turns >= 9)
            {
                gameEnded = true;
            }
            if (!gameEnded)
            {
                AIrequest();
                turns++;
                //check if AI won
                gameEnded = checkThreeLines();
            }
            gameEnded = checkThreeLines() && IsMatrixFull;
        }
        Console.WriteLine("Game over");
        PrintMatrix();
    }
}
}

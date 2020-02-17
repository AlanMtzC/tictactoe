const int MATRIX_SIZE = 3;
//y, x
char[,] matrix = new char[MATRIX_SIZE, MATRIX_SIZE] {{'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'}};
for (int y = 0; y < MATRIX_SIZE; y++) {
    string line = "";
    for (int x = 0; x < MATRIX_SIZE; x++) {
        //Interpolate string
        // Console.WriteLine($"[y, x] = {y}, {x}");
        // Console.Write(matrix[y, x]);
        line += matrix[y, x] + "|";
    }
    Console.WriteLine(line);
    Console.WriteLine("------");
}
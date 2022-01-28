void showPascalTriangle(int[,] pascalTriangle)
{
    int spaceNumbers = pascalTriangle.GetLength(0) ;
    for (int i = 0; i < pascalTriangle.GetLength(0); i++)
    {
        for (int k = 0; k < spaceNumbers; k++)
        {
            Console.Write("  ");
        }
        for (int j = 0; j <= i; j++)
        {
             Console.Write($" {pascalTriangle[i,j]}  ");
        }
        spaceNumbers--;
        Console.WriteLine();
    }
    
   

}
void showMatrix(int[,] matrix )
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j] }");
            }
            Console.WriteLine();
        }
}

int length = 10;
int[,] pascalTriangle = new int[length, length];

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        if (i == j || j == 0)
        {
            pascalTriangle[i,j] = 1;
        }
        else if(i > j)
        {
                 pascalTriangle[i,j] =  pascalTriangle[i-1,j-1] + pascalTriangle[i-1,j];
        }
    }
}
//showMatrix(pascalTriangle);
showPascalTriangle(pascalTriangle);



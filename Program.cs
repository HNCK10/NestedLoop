// See https://aka.ms/new-console-template for more information
// nested loops = loops inside of other loops
// uses vary - Used in a lot of sorting algorithms
//while ()
//{
//    for ()
//    {

//    }
//}
//draw a rectangle with outer loop in charge of counting rows
//inner loop counts columns
Console.Write("How many rows?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns?");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("What symbol?");
String symbol = (Console.ReadLine());
//outer loop - rows, inner loop - columns
//the program will run the first outer loop which will
//take us into the inner loop, for each outer loop
//the inner loops iterations should all be completed
//----------------------------
//This will display a rectangle made from a certain symbol
for (int i=0;i<rows;i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(symbol);
    }
    //Once done you need to move to next row, else 
    //you will just get a straight line of symbols
    Console.WriteLine();
}
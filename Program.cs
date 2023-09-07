namespace Lab_2_ChessBoard
{//Zoran Matovic, NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur stort schackbräde vill du ha?");
            int rows = Convert.ToInt32(Console.ReadLine()); //save userinfo in rows
            int columns = rows;                            //columns is the same as rows

            Console.WriteLine("Hur ska vita rutor se ut?"); //user choose sign for white
            char white = Convert.ToChar(Console.ReadLine()); //convert to char
            Console.WriteLine("Hur ska svarta rutor se ut?");
            char black = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i < rows; i++)   //first loop controls our rows
            {
                for (int j = 0; j < columns; j++) // nested loop controls our columns
                {

                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(white);  //if it´s even we write white
                    }
                    else
                    {
                        Console.Write(black);  //if it´s uneven we write black
                    }
                }

                Console.WriteLine();  //to get a new line


            }







            Console.ReadKey();

        }
    }
}
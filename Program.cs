namespace Lab_2_ChessBoard
{//Zoran Matovic, NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hur stort bräde vill du ha?");
            int rows;

            while (!int.TryParse(Console.ReadLine(), out rows))     //save userinfo in rows
            {
                Console.WriteLine("Endast heltal");
            }
            int columns = rows;         //columns is the same as rows


            for (int i = 0; i < rows; i++)        //first loop controls our rows
            {
                for (int j = 0; j < columns; j++)    // nested loop controls our columns
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("◻︎");  //if it´s even we write whitebox
                    }
                    else
                    {
                        Console.Write("◼︎");  //if it´s uneven we write blackbox
                    }
                }
                Console.WriteLine();
            }



            //We do it again where user choose signs
            Console.WriteLine("\nHur stort bräde vill du ha?");

            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Endast heltal");
            }

            columns = rows;

            Console.WriteLine("Hur ska vita rutor se ut?"); //user choose sign for white
            string white = Console.ReadLine();

            Console.WriteLine("Hur ska svarta rutor se ut?");
            string black = Console.ReadLine();
            Console.WriteLine();


            for (int i = 0; i < rows; i++)   //first loop controls our rows
            {
                for (int j = 0; j < columns; j++) // nested loop controls our columns
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(white + " ");  //if it´s even we write white
                    }
                    else
                    {
                        Console.Write(black + " ");  //if it´s uneven we write black
                    }
                }

                Console.WriteLine();  //to get a new line


            }

            //Do it again with a special sign
            Console.WriteLine("\nHur stort bräde vill du ha?");

            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Endast heltal");
            }

            columns = rows;

            Console.WriteLine("Hur ska vita rutor se ut?"); //user choose sign for white
            white = Console.ReadLine();

            Console.WriteLine("Hur ska svarta rutor se ut?");
            black = Console.ReadLine();

            Console.WriteLine("Hur ska pjäsen se ut?");
            string specialSign = Console.ReadLine();

            Console.WriteLine("Var ska pjäsen stå? (ex E4)");
            string answer = Console.ReadLine();
            int signRow = Convert.ToInt32(answer[0]);
            int signColumn = Convert.ToInt32(answer[1].ToString());
            signRow = signRow - 'A' + 1;                  //only works if user use capital letter!!


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        if ((i + 1) == signColumn && (j + 1) == signRow)
                        {
                            Console.Write(specialSign + " ");
                            continue;
                        }
                        Console.Write(white + " ");
                    }
                    else
                    {
                        if ((i + 1) == signColumn && (j + 1) == signRow)
                        {
                            Console.Write(specialSign + " ");
                            continue;
                        }
                        Console.Write(black + " ");
                    }

                }

                Console.WriteLine();

            }



            Console.ReadKey();

        }
    }
}
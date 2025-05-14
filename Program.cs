namespace ElephantJuggler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            while ( true )
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap" );
                string? input = Console.ReadLine();
                Console.WriteLine( "You pressed " + input );
                if ( input == "1" )
                {
                    Console.WriteLine( "Calling Lloyd's WhoAmI() method" );
                    lloyd.WhoAmI();
                }
                else if ( input == "2" )
                {
                    Console.WriteLine( "Calling Lucinda's WhoAmI() method" );
                    lucinda.WhoAmI();
                }
                else if ( input == "3" )
                {
                    Console.WriteLine( "References have been swapped!" );
                    Elephant temp = lloyd;
                    lloyd = lucinda;
                    lucinda = temp;
                    Console.WriteLine( "Swapped!" );
                }
                else if ( input == "4" )
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4312;
                    lloyd.WhoAmI();
                }
                else
                {
                    return;
                }

            }

        }
    }

    public class Elephant
    {
        public string Name = "";
        public int EarSize = 0;

        public void WhoAmI()
        {
            Console.WriteLine( "I am " + Name );
            Console.WriteLine( "My ears are " + EarSize + " inches long" );
        }


    }
}

﻿namespace ElephantJuggler
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            Elephant[] elephants = new Elephant[ 7 ];
            elephants[ 0 ] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[ 1 ] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[ 2 ] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[ 3 ] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[ 4 ] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[ 5 ] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[ 6 ] = new Elephant() { Name = "Humphrey", EarSize = 45 };

            Elephant biggestEars = elephants[ 0 ];
            for ( int i = 1; i < elephants.Length; i++ )
            {
                Console.WriteLine( "Iteration #" + i );
                if ( elephants[ i ].EarSize > biggestEars.EarSize )
                {
                    biggestEars = elephants[ i ];
                }
                Console.WriteLine( biggestEars.EarSize.ToString() );
            }


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
                else if ( input == "5" )
                {
                    lucinda.SpeakTo( lloyd, "Hello Lloyd!" );
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
        public string? Name;
        public int EarSize = 0;

        public void WhoAmI()
        {
            Console.WriteLine( "I am " + Name );
            Console.WriteLine( "My ears are " + EarSize + " inches long" );
        }

        public void HearMessage( string message, Elephant whoSaidIt )
        {
            Console.WriteLine( Name + " heard a message" );
            Console.WriteLine( whoSaidIt.Name + " said: " + message );
        }

        public void SpeakTo( Elephant whoToTalkTo, string message )
        {
            whoToTalkTo.HearMessage( message, this );
        }

    }

}

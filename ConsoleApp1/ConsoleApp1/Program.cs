
class TheBigBadWolf
{
    public static void Main(string[] args)
    {
        int house = 1; 
        string response = ""; 
        bool gameFinished = false;
        bool hasCode = false;


        while (gameFinished == false)
        {
            if (house == 1)
            {
                Outside();
            }
            else if (house == 2)
            {
                Entryway();
            }
            else if (house == 3)
            {
                UpHall();
            }
            else if (house == 4)
            {
                GhostRoom();
            }
            else if (house == 5)
            {
                WitchRoom();
            }
            else if (house == 6)
            {
                DownHall();
            }
            else if (house == 7)
            {
                VampireRoom();
            }
            else if (house == 8)
            {
                SpiderRoom();
            }
            else if (house == 9)
            {
                EscapeHouse();
            }










        }

        void Outside() 
        {
            Console.WriteLine("It is a cold, stormy, and dark night. It is the middle of October. You come across a haunted house, and you enter. The  door locks behind you, and now you must find a four digit code to escape. What would you like to do? Hint: type in LOOK.Hint 2: the words you must enter will have all the letters capitalized, but when you type it in please type it in       lowercase.");
            response = Console.ReadLine();
            if (response.Equals("look"))
            {
                house = 2;
            }
        }
        void Entryway() 
        {
            Console.WriteLine("You are in an entryway of a haunted house. There are cobwebs and a black cat runs pasts you. There are two staircases. One leads downstairs and one leads upstairs. Where would you like to go; UP or DOWN?");
            response = Console.ReadLine();
            if (response.Equals("up")) 
            {
                house = 3;
            }
            else if (response.Equals("down"))
            {
                house = 6;
            }



        }
        void UpHall()//room 3
        {
            Console.WriteLine("You run to the upstairs hallway. There is a door to your LEFT and a door to your RIGHT. Which door would you like to go in?");
            response = Console.ReadLine();
            if (response.Equals("right")) //ghosts
            {
                house = 4;
            }
            else if (response.Equals("left"))
            {
                house = 5;
            }

        }
        void GhostRoom() 
        {
            Console.WriteLine("You are in a gray room. It is empty besides a floating table and a chalk board. Suddenly, a chalk piece floats and writes a number 2 on the board. Congrats that is the first digit of the code to get out! What would you like to do; run ACROSS the hall, run DOWN to the basement, or go to the door to ENTER the code?");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                house = 5;
            }
            if (response.Equals("down"))
            {
                house = 6;
            }
            else if (response.Equals("enter"))
            {
                EscapeHouse();
            }
        }
        void WitchRoom()
        {
            Console.WriteLine("You are in a dark purple room. In the center of the room a wolf comes at you. You run across to the other room!");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                house = 4;
            }
            if (response.Equals("down"))
            {
                house = 6;
            }
            else if (response.Equals("enter"))
            {
                house = 9;
            }
        }
        void DownHall()
        {
            Console.WriteLine("You run to the basement hallway. There is a door AHEAD and a door BEHIND the stairs. Which door would you like to enter?");
            response = Console.ReadLine();
            if (response.Equals("ahead"))
            {
                house = 7;
            }
            else if (response.Equals("behind"))
            {
                house = 8;
            }
        }
        void VampireRoom() 
        {
            Console.WriteLine("You are in a red room. There is a dark brown wolf in front of you. There is blood on the floor forming of the number 0. Congrats that is the third digit of the code to get out! What would you like to do; run ACROSS the hall, run UP to the next house, or go to the door to ENTER the code?");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                house = 8;
            }
            if (response.Equals("up"))
            {
                house = 3;
            }
            else if (response.Equals("enter"))
            {
                EscapeHouse();
            }
        }
        void SpiderRoom() 
        {
            Console.WriteLine("You are in a dark room. You hear hallowing behind you then a dark figure copmes out from behind you");
            response = Console.ReadLine();
            if (response.Equals("across"))
            {
                house = 7;
            }
            if (response.Equals("up"))
            {
                house = 3;
            }
            else if (response.Equals("enter"))
            {
                house = 9;
            }
        }
        void EscapeHouse()
        {
            Console.WriteLine("You sprint to your house. You come to the door with the keypad. Please enter the code in the digit order that was told.");
            response = Console.ReadLine();
            if (response.Equals("2007"))
            {
                Console.WriteLine("Congrats! You have beat the wolf! Thank you for playing! Happy Halloween!");
                gameFinished = true;
                hasCode = true;
                for (int i = 0; i < 3; i++)
                {



                    Console.WriteLine("roar!");
                }
            }

        }
    }
}


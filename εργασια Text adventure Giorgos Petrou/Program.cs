using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace textgame
{
    class game
    {
        static void Chapter1()
        {
            int choice1;
            Console.WriteLine("You just arrived infront of the gate of the old castle your uncle told you about.");
            Console.WriteLine("He insisted that you dont go anywhere near that place. What will you do?");
            Console.WriteLine("1:Enter the castle at your own risk.");
            Console.WriteLine("2:Search for another way in");
            Console.WriteLine("3:Turn back and leave");

            choice1 = Convert.ToInt32(Console.ReadLine());
            if (choice1 == 1) Enter();
            if (choice1 == 2) anotherway();
            if (choice1 == 3) Leave();
            else Console.WriteLine("Wrong input");
        }

        static void Enter()
        {
            int choice2;
            Console.WriteLine("You entered the castle. Infront of you the big main area, abandoned and delapitated. ");
            Console.WriteLine("To the right is a hallway leading to the dining room.");
            Console.WriteLine("Straight is the main staircase leading to the upstairs rooms.");
            Console.WriteLine("To the left is the entrance to the garden, where will you do?");
            Console.WriteLine("1:Go to the dining room.");
            Console.WriteLine("2:Go up the main staircase.");
            Console.WriteLine("3:Go to the garden.");
            Console.WriteLine("4:Turn back and leave.");

            choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1) Dining();
            if (choice2 == 2) upstairs();
            if (choice2 == 3) Garden();
            if (choice2 == 4) Leave();


        }
        static void Dining()
        {
            int choice3;
            Console.WriteLine("You entered the dining room. There is a big table full of food.");
            Console.WriteLine("The food is freshly cooked. There is also an entrance leading futher into the castle");
            Console.WriteLine("What will you do?");
            Console.WriteLine("1: Sit and have a bite.");
            Console.WriteLine("2: Go furher into the castle.");
            Console.WriteLine("3: Turn back and leave.");

            choice3 = Convert.ToInt32(Console.ReadLine());

            if (choice3 == 1) Eat();
            if (choice3 == 2) Further();
            if (choice3 == 3) Leave();


        }

        static void Eat()
        {
            int choice4;
            Console.WriteLine("The smell of the food was iresistable. You sat down to eat.");
            Console.WriteLine("Suddenly, while you were eating you heard a voice.");
            Console.WriteLine("\"Ahhh, i see you've already started eating.");
            Console.WriteLine(" \"Allow me to introduce my self, im Gabriel Belmond, the lord of this castle.");
            Console.WriteLine("I've been expecting you, but...");
            Console.WriteLine("It appears you dont know the reason you are here.");
            Console.WriteLine("Why are you here?\"");
            Console.WriteLine("1: My uncle told me about this place.");
            Console.WriteLine("2: I was lost and needed somewhere to spend the night.");
   
            choice4 = Convert.ToInt32(Console.ReadLine());
            if (choice4 == 1) Uncle();
            if (choice4 == 2) spendthenight();



        }

        static void Uncle()
        {
            int choice5;
            Console.WriteLine("The old man seemed troubled, he said");
            Console.WriteLine("\"Your uncle? oh i see, i see indeed. Your uncle and i have already met.");
            Console.WriteLine("\"Unfortunately not under the best circumstances, ah doesnt matter.");
            Console.WriteLine("\"You are here now, and i need the help of an outsider like your self.");
            Console.WriteLine("\"You see... Due to some inconvinience i am unable to leave the castle,");
            Console.WriteLine("\"but i really need something from the outer world, really really need something");
            Console.WriteLine("\"Will you help me?\"");
            Console.WriteLine("1: Yes, absolutely.");
            Console.WriteLine("2: No way, im not going to.");
           
            choice5 = Convert.ToInt32(Console.ReadLine());

            if (choice5 == 1) Yes();
            if (choice5 == 2) noway();
                
        }

        static void Yes()
        {
            int choice6;
            Console.WriteLine("The old man was ecstatic. He said...");
            Console.WriteLine("\"Good,Goood... Im very happy indeed. Now im sure you are wondering what it is");
            Console.WriteLine("\"exactly that i need help with. Well you see... I need you to bring me someone here");
            Console.WriteLine("\"Someone to help me with the day to day life because i've gooten old and weak.");
            Console.WriteLine("\"You see your uncle was to be this person but... my condolences.");
            Console.WriteLine("\"So, i say you go out and try to find a person capable as such.");
            Console.WriteLine("\"But first of course let me show you the room you'll spend the night, follow me.\"");
            Console.WriteLine("1: Follow Gabriel upstairs.");
            Console.WriteLine("2: Ask if there is anyone else in the castle.");

            choice6 = Convert.ToInt32(Console.ReadLine());
            if (choice6 == 1) Follow();
            if (choice6 == 2) AnyoneElse();

        }

        static void Follow()
        {
            Console.WriteLine("The old man begun walking up to the rooms to show you where you'll stay.");
            Console.WriteLine("You started following him, through the main area and up the stairs.");
            Console.WriteLine("While on the walkway with the rooms left and right suddenlt you heard a familiar voice");
            Console.WriteLine("It was a scream of agony from a person you know well.");
            Console.WriteLine("Without a second thought you started running through the hallway to reach the room that the voice came from");
            Console.WriteLine("You heard Gabriel screaming in the back for you to stop but you didnt care, the familiarity");
            Console.WriteLine("of that voice was something you couldnt ignore. Finally you reached the room.");
            Console.WriteLine("You gave the door a little push and it opened wide.");
            Console.WriteLine("You shouted loudly as you witnessed your uncle on the other side, tied and almost unconsicous ");
            Console.WriteLine("With his last breath he said only four words...");
            Console.WriteLine("\"Jon, he eats people...\"");
        }
        static void anotherway()
        {
            int choice2;
            Console.WriteLine("You went to the right of the gate to search for another way in.");
            Console.WriteLine("There you found a big wooden door with a piece of metal keeping it locked.");
            Console.WriteLine("The door leads to the cellar. You lifted the metal piece and opened the door.");
            Console.WriteLine("You went down the stairs and immidiately saw the bottles of wine everywhere.");
            Console.WriteLine("On a table there was a book titled \"list of victims\" with a list of names. Your uncle's name was in there.");
            Console.WriteLine("You went forward. You went up the stairs and you ended up in the dining room.");
            Console.WriteLine("There was a table with freshly cooked food and some wine.");
            Console.WriteLine("There is also an entrance leading futher into the castle");
            Console.WriteLine("What will you do?");
            Console.WriteLine("1: Sit and have a bite.");
            Console.WriteLine("2: Go furher into the castle.");
            Console.WriteLine("3: Turn back and leave.");

            choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 == 1) Eat();
            if (choice2 == 2) Further();
            if (choice2 == 3) Leave();
               


        }
        static void Further()
        {
            int choice7;
            Console.WriteLine("You ignored all of the food and continued your search. You came here for a reason after all");
            Console.WriteLine("Deeper into the castle you saw a big golden door with beatiful red fabric.");
            Console.WriteLine("It was pretty clear that what was behind that door was really important.");
            Console.WriteLine("You opened the door end saw and old man sitting at the other side of the room.");
            Console.WriteLine("He said...//Ohh dear not very polite of you to creep in other peoples rooms is it?");
            Console.WriteLine("\"And is see you didnt eat the dinner i prepared for you... ahh no matter");
            Console.WriteLine("\"You are here now, and i need the help of an outsider like your self.");
            Console.WriteLine("\"You see... Due to some inconvinience i am unable to leave the castle,");
            Console.WriteLine("\"but i really need something from the outer world, really really need something");
            Console.WriteLine("\"Will you help me?\"");
            Console.WriteLine("1: Yes, absolutely.");
            Console.WriteLine("2: No way, im not going to.");
            

            choice7 = Convert.ToInt32(Console.ReadLine());
            if (choice7 == 1) Yes();
            if (choice7 == 2) noway();
               

        }

        static void upstairs()
        {
            Console.WriteLine("You went up stairs and into the hallway with the rooms.");
            Console.WriteLine("While on the walkway with the rooms left and right suddenlt you heard a familiar voice");
            Console.WriteLine("It was a scream of agony from a person you know well.");
            Console.WriteLine("Without a second thought you started running through the hallway to reach the room that the voice came from");
            Console.WriteLine("Finally you reached the room.");
            Console.WriteLine("You gave the door a little push and it opened wide.");
            Console.WriteLine("You shouted loudly as you witnessed your uncle on the other side, tied and almost unconsicous ");
            Console.WriteLine("With his last breath he said only four words...");
            Console.WriteLine("\"Jon, he eats people...\"");
        }

        static void Garden()
        {
            int choice8;
            Console.WriteLine("You chose to go to the garden. The garden was filled with beatiful red and yellow");
            Console.WriteLine("flowers that seemed like they have lost their shiningness under the dead of night.");
            Console.WriteLine("You walked forward a bit and infont you, you found a hallway.");
            Console.WriteLine("Every single inch of your body was telling you to not go any further, ");
            Console.WriteLine("but the thought of your uncle still being somewhere around here made you ignore those thoughts");
            Console.WriteLine("While walking down the hallway suddenly on the oposite side an old man appeared.");
            Console.WriteLine("\"What is it that you search for here in this old castle dear traveler?\" said the old man.");
            Console.WriteLine("\"Didnt you know? that it is very rude to go looking into other peoples homes?\"");
            Console.WriteLine("The old man was slowly walking towards you in an aggresive way.");
            Console.WriteLine("You started backing off, feeling like the terrible old man was about to come after you at any minute");
            Console.WriteLine("When out of nowhere, to your left through the balcony you caught a glimpse of a figure in a cell");
            Console.WriteLine("waving and screaming at you. There was no mistake in your head, that figure was your uncle.");
            Console.WriteLine("1: Start running towards your uncle.");
            Console.WriteLine("2: Charge and attack the old man.");

            choice8 = Convert.ToInt32(Console.ReadLine());
            if (choice8 == 1) RUN();
            if (choice8 == 2) attack();

        }
        static void RUN()
        {
            Console.WriteLine("You immidiately started running towards your uncle. You went back through the garden and up the staircase");
            Console.WriteLine("Finally you reached the room.");
            Console.WriteLine("You gave the door a little push and it opened wide.");
            Console.WriteLine("You shouted loudly as you witnessed your uncle on the other side, tied and almost unconsicous ");
            Console.WriteLine("With his last breath he said only four words...");
            Console.WriteLine("\"Jon, he eats people...\"");

        }

        static void spendthenight()
        {
            int choice9;
            Console.WriteLine("\"Ohh just a lost traveler... looking for a place to spend the night...");
            Console.WriteLine("\"Lets say i let you sleep here in my castle for the night, and you do a little");
            Console.WriteLine("\"favor for me. I'll let you know tomorrow when you wake up what that favor is...");
            Console.WriteLine("What say you?");
            Console.WriteLine("1: Yes i will accept that offer.");
            Console.WriteLine("2: No way, i will not accept.");

            choice9 = Convert.ToInt32(Console.ReadLine());
            if (choice9 == 1) Yes();
            if (choice9 == 2) noway();

        }

        static void noway()
        {
            Console.WriteLine("\"HOW DARE YOU DECLINE MY OFFER YOU PUNY HUMAN");
            Console.WriteLine("\"IM THE LORD OF THIS CASTLE, I'VE LIVED A THOUSAND LIFES\"");
            Console.WriteLine("The words came out of his mouth like bullets, you took a step back");
            Console.WriteLine("but something inside you knew it was already too late.");
            Console.WriteLine("With the spped of a demon he launched at you covering a long distance with just one jump.");
            Console.WriteLine("His claws were sharp, as he ripped through your flesh, with the speed of a mad dog.");
            Console.WriteLine("Your death came quickly, it was like a gift, to not make you suffer...");
            Console.WriteLine("Like your uncle did...");
        }

        static void AnyoneElse()
        {
            Console.WriteLine("\"Any one else? No, there is no one here beside us.\"");
            Console.WriteLine("As those words came out of his mouth a terrible scream was heard throughout the castle");
            Console.WriteLine("Immidiately you started running towards the source of the scream, you went up the stairs,");
            Console.WriteLine("You gave the door a little push and i opened wide. Behind was your uncle, laying there alsmos dead.");
            Console.WriteLine("You screamed in terror as you realised what was going on...");
            Console.WriteLine("He used his last breath to say four words to you...");
            Console.WriteLine("Jon, he eats people.");
        }

        static void attack()
        {
            Console.WriteLine("You charged to the old man. Your anger blinded you and you couldnt think clearly.");
            Console.WriteLine("It wasnt hard for the old man to strike back and end you in one swift strike.");
            Console.WriteLine("You died.");
        }
        
        static void Leave()
        {
            Console.WriteLine("You decided to turn back and leave");
            Console.WriteLine("It was the best choice.");
            Console.WriteLine("The game will start again.");
            Chapter1();
        }

        static void Main(string[] args)
        {
            Chapter1();
        }




    }
}
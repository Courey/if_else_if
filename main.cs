using System;
namespace VideoGame
{

   class Character
   {
      private string mCharacterType;
      private int mCharacterLevel;
      private double mCharacterHP;

      // getters: pCharacterType, pCharacterLevel, pCharacterHP.
      public string getCharacterType()
      {
         return mCharacterType;
      }

      public int getCharacterLevel()
      {
         return mCharacterLevel;
      }

      public double getCharacterHP()
      {
         return mCharacterHP;
      }


      // setters: pCharacterType, pCharacterLevel, pCharacterHP.
      public void setCharacterType(string type)
      {
         mCharacterType = type;
         // if statements can go in here, but was requested in main method.
      }

      public void setCharacterLevel(int level)
      {
         mCharacterLevel = level;
      }

      public void setCharacterHP(double HP)
      {
         mCharacterHP = HP;
      }


      // ToString method
      public override string ToString()
      {
         return getCharacterType()+"(Level: "+getCharacterLevel()+")"+'\n'+" Health status:"+'\n'+ getCharacterHP();
      }


      //Constructor: Character
      public Character(string characterType, int characterLevel, double characterHP)
      {
         setCharacterType(characterType);
         setCharacterLevel(characterLevel);
         setCharacterHP(characterHP);
      }


      public class TestCharacter
      {
         public static void Main(string[] args)
         {
            //instances of constructor for testing.
            Character character1 = new Character("hero", 5, 7.0);
            
            //Type options, default, and error handling.
// *I feel like it's more efficient to place these if statements in the setter/accessor methods so they don't need to be
// *re-typed for each instance of the constructor. Is this accurate? Why did you want them in the Main method (or did
// *I just fail at interpreting the directions)?
            
            if (character1.getCharacterType() == "hero") // 1st player
            {
               character1.setCharacterType("Brave Hero");
            }
            else if (character1.getCharacterType() == "monster") // The bad guy. Really bad. Scary bad. 
            {
               character1.setCharacterType("Monster");
            }
            else if (character1.getCharacterType() == "NCP") // Non-controller player. Any computer driven character that joins the party.
            {
               character1.setCharacterType("2 player-NCP");
            }
            else if (character1.getCharacterType() == "plotCharacter") // Peasants. Can't esacape them, they're everywhere. 
            {
               character1.setCharacterType("Towns Person");
            }
            else if (character1.getCharacterType() == "mutant") // default setting for error handling.
            {
               Console.WriteLine("GAME OVER /n You have already lost because you couldn't even pick a character without screwing up.");
               Console.WriteLine("Press any key after seriously considering whether or not you're gaming material.");
               Console.ReadLine();
            }
            else // Pure, unadulterated superstition. I don't think this is possible, but if I don't put it in, it will be.
               // Update 1/16/13: It's possible. I checked. 
            {
               Console.WriteLine("The cake is a lie.");
               Console.ReadLine();
            }

            if (character1.mCharacterLevel >= 0)
            {// level options, test, and methods.
               if (character1.mCharacterLevel == 10)
               {
                  character1.setCharacterLevel(99);
               }
               else
               {
                  character1.setCharacterLevel(character1.mCharacterLevel * 10);
               }
               
            }//end positive level if loop.
            else
            {
               Console.WriteLine("Your character is currently experiencing a terminal technical difficulty: negative IQ.");
            }

            // HP options, test, and methods.
            if (character1.mCharacterHP >= 1)
            {
               // Live player code.
               if (character1.mCharacterHP == 10)
               {
                  character1.setCharacterHP(.11111111111);
               }
               else if (character1.mCharacterHP == 9)
               {
                  character1.setCharacterHP(.11111111101);
               }
               else if (character1.mCharacterHP == 8)
               {
                  character1.setCharacterHP(.11111111001);
               }
               else if (character1.mCharacterHP == 7)
               {
                  character1.setCharacterHP(.11111110001);
               }
               else if (character1.mCharacterHP == 6)
               {
                  character1.setCharacterHP(.11111100001);
               }
               else if (character1.mCharacterHP == 5)
               {
                  character1.setCharacterHP(.11111000001);
               }
               else if (character1.mCharacterHP == 4)
               {
                  character1.setCharacterHP(.11110000001);
               }
               else if (character1.mCharacterHP == 3)
               {
                  character1.setCharacterHP(.11100000001);
               }
               else if (character1.mCharacterHP == 2)
               {
                  character1.setCharacterHP(.110000000001);
               }
               else if (character1.mCharacterHP == 1)
               {
                  character1.setCharacterHP(.10000000001);
               }
            }
            else
            {
               Console.WriteLine("GAME OVER. /n /n /n Oh look, you're dead. /n /n /n The princess is probably pissed, have fun getting out of that one Champ.");
            }

            Console.WriteLine(character1.ToString());
            Console.ReadLine();
         }

      }
   }
}

/* 
Ironically, I only got 1 error. error I got was "The cake is a lie." and it was just too funny not to leave in there. 
*/

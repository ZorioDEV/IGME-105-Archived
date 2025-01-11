using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBall_STARTER
{

    // *****************************************
    // *** Add XML comments to this class!   ***
    // *****************************************
    /// <summary>
    /// Randomly 
    /// </summary>
    internal class MagicEightBall
    {
        // --------------------------------------------------------------------
        // Fields of this class
        // --------------------------------------------------------------------

        // 2 included fields from the exercise
        private string[] responses;
        private Random randomGenerator;

        // *************************************************************
        // TODO: Declare the other 2 fields (owner and timesShaken) here!
        // *************************************************************
        public string owner;
        public int timesShaken;

        // --------------------------------------------------------------------
        // Constructors of this class
        // --------------------------------------------------------------------

        // *****************************************
        // TODO: Add comments to this constructor!
        // *****************************************

        /// <summary>
        /// Defualt constructor for 8 Ball with set variables & random generation.
        /// </summary>
        public MagicEightBall()
        {
            // Initialize the Random object.
            randomGenerator = new Random();

            // Initialize the responses array with 1 response.
            responses = new string[5];
            responses[0] = "It is certain";

            // *******************************************************
            // TODO: Assign 4 more responses to the responses array!
            // *******************************************************
            responses[1] = "Never";
            responses[2] = "Most Likely";
            responses[3] = "Try Again";
            responses[4] = "Maybe";


            // *******************************************************
            // TODO: Assign default value to owner and timesShaken fields!
            // *******************************************************
            owner = "Person";
            timesShaken = 0;

        }

        // *****************************************************
        // TODO: Create parameterized constructor! Add XML comments!
        // *****************************************************
        /// <summary>
        /// Parameterized contructor for 8 Ball with custom variables & random generation.
        /// </summary>
        /// <param name="owner">custom name given</param>
        public MagicEightBall(string owner)
        {
            // *** VARIABLES USED ***
            // name prompted from user
            this.owner = owner;
            // defualt feilds
            timesShaken = 0;
            randomGenerator = new Random();
            responses = new string[5];
            // response options
            responses[0] = "It is certain";
            responses[1] = "Never";
            responses[2] = "Not Likely";
            responses[3] = "Try Again";
            responses[4] = "Maybe";
        }



        // --------------------------------------------------------------------
        // Methods of this class
        // --------------------------------------------------------------------


        // *****************************************
        // TODO: Add XML comments to this method!
        // *****************************************

        /// <summary>
        /// Randomly generates a set of responses & adds to the shake count.
        /// </summary>
        /// <returns>string of random response</returns>
        public string ShakeBall()
        {
            // Randomly chooses one of the 5 possible responses
            // Next(0, 5) will return 0, 1, 2, 3, or 4.  
            int randomNumber = randomGenerator.Next(0, 5);

            // Retrieve that randomly chosen index from the responses array
            //   and save the value in a string variable.
            string randomResponse = responses[randomNumber];

            // *******************************************
            // TODO: Update times shaken!
            // *******************************************
            timesShaken++;

            // *******************************************
            // TODO: Return randomly chosen response!
            // *******************************************

            // Change this to return the correct thing.
            return $" > The Magic 8 ball says: {randomResponse}.";
        }


        // *****************************************************
        // TODO: Create the Report method here! Add XML comments!
        // *****************************************************
        /// <summary>
        /// Reports back to the user how many times they've shaken the ball.
        /// </summary>
        /// <returns>string of report</returns>
        public string Report()
        {
            // if shaken 0 times
            if (timesShaken == 0)
            {
                return $" > {owner} has not shaken the ball yet.";
            }
            // if shaken between 1-2 times 
            else if (timesShaken > 0 && timesShaken < 3)
            {
                return $" > {owner} has shaken the ball {timesShaken} time(s).";
            }
            // if shaken above 3 times print that theyve asked a lot of questions
            else
            {
                return $" > {owner} has shaken the ball {timesShaken} time(s). That's a lot of questions!";
            }
            
        }


    }
}

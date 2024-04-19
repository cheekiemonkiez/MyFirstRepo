using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoCodingChallenge
{
    internal class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives) 
        {
            this.name = name;
            livesLeft = startingLives;
        }

        public int GetScore()
        {
            return score;
        }

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        public void kill()
        {
            if (livesLeft > 0) 
            {
                livesLeft--;
            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }
    }
}

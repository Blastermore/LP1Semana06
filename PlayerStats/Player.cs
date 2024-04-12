using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public float HighScore   
        {
            set
            {
                if (value > highScore)
                    highScore = value;
                
            }
        }
        public string Name{get;}
        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0;
                }
                else
                {
                    return wonGames/playedGames;
                }
            }
        }
        public Player(name)
        {
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }

        public void PlayGame(bool win)
        {
            playedGames += 1;
            if (win == true)
            {
                wonGames += 1;
            }
        }
    }
}
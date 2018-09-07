using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Syy.Data
{
    public class PlayerStats : ScriptableObject
    {
        public int highScore;
        public int totalScore;
        public float timeSpent;
        public int numberOfGames;

        public void ClearStats()
        {
            highScore = 0;
            totalScore = 0;
            timeSpent = 0;
            numberOfGames = 0;
        }
    }
}

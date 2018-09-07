using UnityEngine;
using Syy.Manager;
namespace Syy.Manager
{
    public class ScoreManager : MonoBehaviour
    {
        public int currentScore = 0;
        public int highScore;

        void Awake()
        {
            if(Managers.Game.stats.highScore != 0)
            {
                highScore = Managers.Game.stats.highScore;
                Managers.UI.inGameUI.UpdateScoreUI();
            }
        }
    }
}

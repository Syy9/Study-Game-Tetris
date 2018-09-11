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
            } else {
                highScore = 0;
                Managers.UI.inGameUI.UpdateScoreUI();
            }
        }

        public void OnScore(int scoreIncreateAmount)
        {
            currentScore += scoreIncreateAmount;
            CheckHighScore();
            Managers.UI.inGameUI.UpdateScoreUI();
            Managers.Game.stats.totalScore += scoreIncreateAmount;
        }

        public void CheckHighScore()
        {
            if(highScore < currentScore)
            {
                highScore = currentScore;
            }
        }

        public void ResetScore()
        {
            currentScore = 0;
            highScore = Managers.Game.stats.highScore;
            Managers.UI.inGameUI.UpdateScoreUI();
        }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Syy.Manager;
using DG.Tweening;

namespace Syy.UI
{
    public class InGameUI : MonoBehaviour
    {
        [SerializeField] Text score;
        [SerializeField] Text highScore;
        [SerializeField] Text scoreLabel;
        [SerializeField] Text highScoreLabel;
        [SerializeField] GameObject gameOverPopUp;

        public void UpdateScoreUI()
        {
            score.text = Managers.Score.currentScore.ToString();
            highScore.text = Managers.Score.highScore.ToString();
        }

        public void InGameUIStartAnimation()
        {
            scoreLabel.rectTransform.DOAnchorPosY(-334, 1, true);
            highScoreLabel.rectTransform.DOAnchorPosY(-334, 1, true);
            score.rectTransform.DOAnchorPosY(-375, 1, true);
            highScore.rectTransform.DOAnchorPosY(-375, 1, true);
        }

        public void InGameUIEndAnimation()
        {
            scoreLabel.rectTransform.DOAnchorPosY(-334 + 650, 0.3f, true);
            highScoreLabel.rectTransform.DOAnchorPosY(-334 + 650, 0.3f, true);
            score.rectTransform.DOAnchorPosY(-375 + 650, 0.3f, true);
            highScore.rectTransform.DOAnchorPosY(-375 + 650, 0.3f, true);
        }
    }
}

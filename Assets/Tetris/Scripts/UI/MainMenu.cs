using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Syy.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] Text tetrisLogoText;
        [SerializeField] GameObject menuButtons;
        [SerializeField] GameObject restartButton;
        [SerializeField] HorizontalLayoutGroup layout;

        void Awake()
        {
            layout = GetComponent<HorizontalLayoutGroup>();
        }

        void OnEnable()
        {
            tetrisLogoText.enabled = true;
            menuButtons.SetActive(true);
        }

        void OnDisable()
        {
            tetrisLogoText.enabled = false;
            menuButtons.SetActive(false);
        }

        public void DisableMenuButtons()
        {
            menuButtons.SetActive(false);
        }

        public void MainMenuStartAnimation()
        {
            menuButtons.GetComponent<RectTransform>().DOAnchorPosY(-850, 1, true);
            tetrisLogoText.GetComponent<RectTransform>().DOAnchorPosY(600, 1, true);
        }

        public void MainMenuEndAnimation()
        {
            menuButtons.GetComponent<RectTransform>().DOAnchorPosY(-1450, 0.3f, true);
            tetrisLogoText.GetComponent<RectTransform>().DOAnchorPosY(1200, 0.3f, true);
        }
    }
}

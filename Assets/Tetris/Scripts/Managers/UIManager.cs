using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Syy.Manager;
using Syy.UI;

namespace Syy.Manager
{
    public enum Menus
    {
        Main,
        Ingame,
        GameOver,
    }
    public class UIManager : MonoBehaviour
    {
        [SerializeField] MainMenu mainMenu;
        [SerializeField] public InGameUI inGameUI;
        [SerializeField] PopUp popUp;
        [SerializeField] public GameObject activePopUp;
        [SerializeField] GameObject panel;

        public void ActivateUI(Menus menuType)
        {
            if(menuType == Menus.Main)
            {
                StartCoroutine(ActivateMainMenu());
            } else if (menuType == Menus.Ingame)
            {
                StartCoroutine(ActivateInGameUI());
            }
        }

        IEnumerator ActivateMainMenu()
        {
            inGameUI.InGameUIEndAnimation();
            inGameUI.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.3f);
            mainMenu.gameObject.SetActive(true);
            mainMenu.MainMenuStartAnimation();
        }

        IEnumerator ActivateInGameUI()
        {
            mainMenu.MainMenuEndAnimation();
            yield return new WaitForSeconds(0.3f);
            mainMenu.gameObject.SetActive(false);
            inGameUI.gameObject.SetActive(true);
            inGameUI.InGameUIStartAnimation();
        }

        void Update()
        {
            if(activePopUp != null)
            {
                HideIfClickedOutside(activePopUp);
            }
        }

        public void MainMenuArrange()
        {
            if(Managers.Game.isGameActive)
            {
                mainMenu.layout.spacing = 20;
                mainMenu.layout.padding.left = mainMenu.layout.padding.right = 200;
                mainMenu.restartButton.SetActive(true);
            } else {
                mainMenu.layout.spacing = 50;
                mainMenu.layout.padding.left = mainMenu.layout.padding.right = 250;
                mainMenu.restartButton.SetActive(false);
            }
        }

        private void HideIfClickedOutside(GameObject outsidePanel)
        {
            if (Input.GetMouseButton(0) && outsidePanel.activeSelf &&
                !RectTransformUtility.RectangleContainsScreenPoint(
                    outsidePanel.GetComponent<RectTransform>(),
                    Input.mousePosition,
                    Camera.main
                ))
                {
                    outsidePanel.SetActive(false);
                    outsidePanel.transform.parent.gameObject.SetActive(false);
                    Managers.UI.panel.SetActive(false);
                    activePopUp = null;
                }
        }
    }

}

using System.Collections;
using UnityEngine;
using Syy.Manager;

namespace Syy.UI
{

    public class PopUp : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPopUp;
        [SerializeField] GameObject settingsPopUp;
        [SerializeField] GameObject playerStatsPopUp;

        public void ActivateGameOverPopUp()
        {
            gameOverPopUp.transform.parent.gameObject.SetActive(true);
            gameOverPopUp.SetActive(true);
            Managers.UI.activePopUp = gameOverPopUp;
        }

        public void ActivateSettingsPopUp()
        {
            settingsPopUp.transform.parent.gameObject.SetActive(true);
            settingsPopUp.SetActive(true);
            Managers.UI.activePopUp = settingsPopUp;
        }

        public void ActivatePlayerStatsPopUp()
        {
            playerStatsPopUp.transform.parent.gameObject.SetActive(true);
            playerStatsPopUp.SetActive(true);
            Managers.UI.activePopUp = playerStatsPopUp;
        }
    }

}

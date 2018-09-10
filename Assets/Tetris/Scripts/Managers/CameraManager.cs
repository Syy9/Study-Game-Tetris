using UnityEngine;
using DG.Tweening;
using System.Collections;

namespace Syy.Manager
{
    public class CameraManager : MonoBehaviour
    {
        public Camera main;
        float _mainMenuSize = 13.5f;
        float _inGameSize = 11f;
        [HideInInspector] public CameraShake _shaker;
        void Awake()
        {
            _shaker = main.gameObject.GetComponent<CameraShake>();
        }

        public void ZoomIn()
        {
            if(main.orthographicSize != _inGameSize)
            {
                main.DOOrthoSize(_inGameSize, 1f).SetEase(Ease.OutCubic).OnComplete(() => {
                    StartCoroutine(StartGamePlay());
                });
            } else {
                Manager.SpawnManager.Spawn();
                Managers.Game.isGameActive = true;
            }
        }

        public void ZoomOut()
        {
            if(main.orthographicSize != _mainMenuSize)
            {
                main.DOOrthoSize(_mainMenuSize, 1f).SetEase(Ease.OutCubic);
            }
        }

        IEnumerator StartGamePlay()
        {
            yield return new WaitForEndOfFrame();
            if(!Managers.Game.isGameActive)
            {
                Managers.Spawner.Spawn();
                Managers.Game.isGameActive = true;
            }
            yield break;
        }
    }
}

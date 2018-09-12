using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Syy.Manager
{
    public class Managers : MonoBehaviour
    {
        public static GameManager Game;
        public static UIManager UI;
        public static AudioManager Audio;
        public static ColorManager Color;
        public static CameraManager Camera;
        public static GridManager Grid;
        public static ScoreManager Score;
        public static SpawnManager Spawner;
        public static PlayerInputManager Input;
        void Awake()
        {
            Game = GetComponent<GameManager>();
            UI = GetComponent<UIManager>();
            Audio = GetComponent<AudioManager>();
            Color = GetComponent<ColorManager>();
            Camera = GetComponent<CameraManager>();
            Grid = GetComponent<GridManager>();
            Score = GetComponent<ScoreManager>();
            Spawner = GetComponent<SpawnManager>();
            Input = GetComponent<PlayerInputManager>();
            DontDestroyOnLoad(gameObject);
        }
    }

}

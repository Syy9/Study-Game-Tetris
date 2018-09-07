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
        void Awake()
        {
            Game = GetComponent<GameManager>();
            UI = GetComponent<UIManager>();
            Audio = GetComponent<AudioManager>();
            DontDestroyOnLoad(gameObject);
        }
    }

}

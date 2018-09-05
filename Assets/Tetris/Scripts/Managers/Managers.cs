using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Syy.Manager
{
    public class Managers : MonoBehaviour
    {
        static GameManager Game;
        void Awake()
        {
            Game = GetComponent<GameManager>();
            DontDestroyOnLoad(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using Syy.State;
using UnityEngine;

namespace Syy.Manager {

    public class GameManager : MonoBehaviour
    {
        public bool isGameActive;
        private StateBase currentState;

        void Awake()
        {
            isGameActive = false;
        }

        void Start()
        {
            SetState(typeof(Syy.State.MenuState));
        }

        void Update()
        {
            if(currentState != null)
            {
                currentState.OnUpdate();
            }
        }

        public void SetState(System.Type stateType)
        {
            if(currentState != null)
            {
                currentState.OnDeactivate();
            }

            currentState = GetComponentInChildren(stateType) as StateBase;
            if(currentState != null)
            {
                currentState.OnActivate();
            }
        }
    }

}

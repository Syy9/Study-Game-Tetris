using UnityEngine;

namespace Syy.Manager
{
    public enum InputMethod
    {
        KeyboardInput,
        MouseInput,
        TouchInput,
    }
    public class PlayerInputManager : MonoBehaviour
    {
        public bool isActive;
        public InputMethod inputType;

        void Update()
        {
            if(isActive)
            {
                if(inputType == InputMethod.KeyboardInput)
                {

                } else if(inputType == InputMethod.MouseInput)
                {

                } else {
                    
                }
            }
        }
    }
}

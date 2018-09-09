using UnityEngine;

namespace Syy.Manager
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject[] shapeTypes;
        public void Spawn()
        {
            int i = Random.RandomRange(0, shapeTypes.Length);
            GameObject temp = Instantiate(shapeTypes[i]);
            Managers.Game.currentShape = temp.GetComponent<TetrisShape>();
            temp.transform.parent = Managers.Game.blockHolder;
            Managers.Input.isAttack = true;
        }
    }
}

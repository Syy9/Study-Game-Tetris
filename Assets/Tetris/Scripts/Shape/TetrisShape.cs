using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using Syy.Manager;

namespace Syy.Shape
{
    public enum ShapeType
    {
        I,
        T,
        O,
        L,
        J,
        S,
        Z,
    }

    public class TetrisShape : MonoBehaviour
    {
        [HideInInspector] public ShapeType type;
        [HideInInspector] public ShapeMovementController movementController;

        void Awake()
        {
            movementController = GetComponent<ShapeMovementController>();

        }

        void Start()
        {
            if(!Managers.Grid.InValidGridPosition(this.transform))
            {
                Managers.Game.SetState(GameOverState);
                Destroy(this.gameObject);
            }
        }

        void AssignRandomColor()
        {
            Color temp = Managers.Palette.TurnRandomColorFromTheme();
            foreach (var renderer in GetComponentsInChildren<SpriteRenderer>().ToList())
            {
                renderer.color = temp;
            }
        }
    }
}

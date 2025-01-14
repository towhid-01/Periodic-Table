using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class OnColliosinMoveSpeedZero : MonoBehaviour
    {
        public ElementsMovements elementsMovements;

        void OnCollisionEnter2D(Collision2D collision)
        {
            elementsMovements.moveSpeed = 0f;
        }
    }
}

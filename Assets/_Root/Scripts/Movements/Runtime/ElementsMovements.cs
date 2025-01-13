using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class ElementsMovements : MonoBehaviour
    {
        public float moveSpeed = 0.5f;
        public bool showDebugLine = true;
    
        void Update()
        {
            Vector2 nucleusPos = NucleusPosition.TransformInstance.position;
            Vector2 enemyPos = transform.position;
            Vector2 difference = nucleusPos - enemyPos;
            var getAngleZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            var angleZ = getAngleZ - 90;
            transform.eulerAngles = new Vector3(0, 0, angleZ);
            transform.position = Vector3.MoveTowards(transform.position, nucleusPos, moveSpeed * Time.deltaTime);
            
        }
    }
}
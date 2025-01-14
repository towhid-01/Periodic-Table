using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class ElementsMovements : MonoBehaviour
    {
        public float moveSpeed = 0.5f;
        public bool showDebugLine = true;
    
        void Update()
        {
            Vector2 spawnerPos = SpawnerManager.TransformInstance.position;
            Vector2 subatomicParticlesPos = transform.position;
            Vector2 difference = spawnerPos - subatomicParticlesPos;
            var getAngleZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            var angleZ = getAngleZ - 90;
            transform.eulerAngles = new Vector3(0, 0, angleZ);
            transform.position = Vector3.MoveTowards(transform.position, spawnerPos, moveSpeed * Time.deltaTime);
            
        }
    }
}
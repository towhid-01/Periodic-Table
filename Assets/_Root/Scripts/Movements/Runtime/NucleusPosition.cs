using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class NucleusPosition : MonoBehaviour
    {
        public static Transform TransformInstance;
        private void Awake()
        {
            TransformInstance = this.transform;
        
        }
    }
}
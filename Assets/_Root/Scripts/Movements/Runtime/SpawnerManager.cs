using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class SpawnerManager : MonoBehaviour
    {
        public static Transform TransformInstance;
        private void Awake()
        {
            TransformInstance = this.transform;
            Debug.Log(TransformInstance,this);
        
        }
    }
}
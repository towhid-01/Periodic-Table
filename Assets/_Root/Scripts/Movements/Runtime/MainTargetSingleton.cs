using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class MainTargetSingleton : MonoBehaviour
    {
        public static Transform transformInstance;
        private void Awake()
        {
            transformInstance = transform;
        }
    }
}
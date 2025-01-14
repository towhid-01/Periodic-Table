using UnityEngine;

namespace _Root.Scripts.Score.Runtime
{
    public class OnDestroyIncreaseCounter : MonoBehaviour
    {
        public CounterScriptableObject counterScriptableObject;
        private void OnDestroy() => counterScriptableObject.count++;
    }
}
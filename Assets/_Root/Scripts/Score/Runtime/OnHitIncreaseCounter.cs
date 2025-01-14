using UnityEngine;

namespace _Root.Scripts.Score.Runtime
{
    public class OnHitIncreaseCounter : MonoBehaviour
    {
        public CounterScriptableObject counterScriptableObject;
        public void OnCollisionEnter2D(Collision2D other) => counterScriptableObject.count++;
    }
}
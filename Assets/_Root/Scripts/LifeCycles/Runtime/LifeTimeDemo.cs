using _Root.Scripts.Healths.Runtime;
using Pancake.Common;
using UnityEngine;

namespace _Root.Scripts.LifeCycles.Runtime
{
    public class LifeTimeDemo : MonoBehaviour
    {
        public Health health;

        private void OnEnable()
        {
            health.OnHealthChanged += Health_onHealthChanged;
        }

        private void Health_onHealthChanged(int currentHealth)
        {
            Debug.Log("Health changed to: " + currentHealth, this);
        }
        
        
        private void OnDisable()
        {
            health.OnHealthChanged -= Health_onHealthChanged;
        }

        private void Reset()
        {
            health = GetComponent<Health>();
        }
    }
}
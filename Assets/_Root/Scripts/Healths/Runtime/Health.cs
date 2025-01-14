using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace _Root.Scripts.Healths.Runtime
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int health = 100;
        public UnityAction<int> OnHealthChanged;

        [Button]
        public void SetHealth(int value)
        {
            health = value;
            OnHealthChanged.Invoke(health);
        }

        public int GetHealth() => health;
    }
}
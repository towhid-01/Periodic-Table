using _Root.Scripts.Elements.Runtime;
using UnityEngine;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    public class ElementSpawner : MonoBehaviour
    {
        public ElementScriptableObject element;
        
        private void Start()
        {
            Debug.Log(element);
        }
    }
}
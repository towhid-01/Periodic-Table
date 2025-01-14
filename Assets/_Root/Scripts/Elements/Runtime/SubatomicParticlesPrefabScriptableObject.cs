using UnityEngine;

namespace _Root.Scripts.Elements.Runtime
{
    [CreateAssetMenu(fileName = "ElementsPrefabScriptableObject", menuName = "Scriptable Objects/ElementsPrefabScriptableObject")]
    public class SubatomicParticlesPrefabScriptableObject : ScriptableObject
    {
        public GameObject protons;
        public GameObject neutrons;
        public GameObject electrons;
    }
}

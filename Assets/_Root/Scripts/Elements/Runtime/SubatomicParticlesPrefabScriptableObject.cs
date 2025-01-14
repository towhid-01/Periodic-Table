using UnityEngine;
using UnityEngine.Serialization;

namespace _Root.Scripts.Elements.Runtime
{
    [CreateAssetMenu(fileName = "ElementsPrefabScriptableObject", menuName = "Scriptable Objects/ElementsPrefabScriptableObject")]
    public class SubatomicParticlesPrefabScriptableObject : ScriptableObject
    {
        [FormerlySerializedAs("protons")] public GameObject proton;
        [FormerlySerializedAs("neutrons")] public GameObject neutron;
        [FormerlySerializedAs("electrons")] public GameObject electron;
    }
}

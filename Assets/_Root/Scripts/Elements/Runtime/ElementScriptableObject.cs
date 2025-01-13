using UnityEngine;

namespace _Root.Scripts.Elements.Runtime
{
    [CreateAssetMenu(fileName = "Elements", menuName = "Scriptable/Element", order = 1)]
    public class ElementScriptableObject : ScriptableObject
    {
        public string elementName;
        public int neutronCount = 1;
        public int protonCount = 0;
        public int electronCount = 1;

        public override string ToString()
        {
            return
                $"{nameof(elementName)}: {elementName}, {nameof(neutronCount)}: {neutronCount}, {nameof(protonCount)}: {protonCount}, {nameof(electronCount)}: {electronCount}";
        }
    }
}
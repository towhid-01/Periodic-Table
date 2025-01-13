using UnityEngine;

namespace _Root.Scripts.Elements.Runtime
{
    [CreateAssetMenu(fileName = "Elements", menuName = "Scriptable/Element", order = 1)]
    public class ElementScriptableObject : ScriptableObject
    {
        public string elementName;
        public int neutrons = 1;
        public int protons = 0;
        public int electrons = 1;

        public override string ToString()
        {
            return
                $"{nameof(elementName)}: {elementName}, {nameof(neutrons)}: {neutrons}, {nameof(protons)}: {protons}, {nameof(electrons)}: {electrons}";
        }
    }
}
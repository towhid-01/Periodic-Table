using System.Collections.Generic;
using UnityEngine;

namespace _Root.Scripts.Elements.Runtime
{
    public class SelectedElementsScriptableObject : ScriptableObject
    {
        public int selectedElementIndex;
        public List<ElementScriptableObject> scriptableElements;

        public void Forget() => selectedElementIndex = 0;

        public ElementScriptableObject GetCurrentElement() => scriptableElements[selectedElementIndex];

        public int NextLevel()
        {
            ++selectedElementIndex;
            Debug.Log(selectedElementIndex);
            return selectedElementIndex;
        }
    }
}
using System;
using _Root.Scripts.Elements.Runtime;
using UnityEngine;

namespace _Root.Scripts.Score.Runtime
{
    public class ResetOnUI : MonoBehaviour
    {
        public SelectedElementsScriptableObject selectedElementsScriptableObject;
        private void Awake() => selectedElementsScriptableObject.Forget();
    }
}
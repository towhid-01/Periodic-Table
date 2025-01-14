using System;
using _Root.Scripts.Elements.Runtime;
using Pancake.Common;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace _Root.Scripts.UIShowElements.Runtime
{
    public class UIShowElements : MonoBehaviour
    {
        [SerializeField] private Image elementBG;
        [SerializeField] private TMP_Text nameTMP;
        [SerializeField] private TMP_Text electronCountTMP;

        [FormerlySerializedAs("currentElement")] [SerializeField]
        private int currentElementIndex = 0;

        [SerializeField] private SelectedElementsScriptableObject selectedElementsScriptableObject;

        private void Start()
        {
            SetElement(selectedElementsScriptableObject.GetCurrentElement());
        }

        private void SetElement(ElementScriptableObject elementScriptableObject)
        {
            nameTMP.text = elementScriptableObject.elementShortName;
            electronCountTMP.text = elementScriptableObject.electrons.ToString();
        }
    }
}
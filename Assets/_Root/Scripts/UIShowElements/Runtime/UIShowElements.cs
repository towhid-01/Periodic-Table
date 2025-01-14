using System;
using _Root.Scripts.Elements.Runtime;
using Pancake.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Root.Scripts.UIShowElements.Runtime
{
    public class UIShowElements : MonoBehaviour
    {
        [SerializeField] private Image elementBG;
        [SerializeField] private TMP_Text nameTMP;
        [SerializeField] private TMP_Text electronCountTMP;
        [SerializeField] private string elementName;
        [SerializeField] private int currentElement = 1;
        [SerializeField] private ElementScriptableObject currentElementScriptableObject;

        private void Start()
        {
            currentElement = Data.Load(elementName, 1);
            SetElement(currentElementScriptableObject);
        }

        private void SetElement(ElementScriptableObject elementScriptableObject)
        {
            nameTMP.text = elementScriptableObject.elementName;
            electronCountTMP.text = elementScriptableObject.electrons.ToString();
        }
    }
}
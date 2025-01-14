using System;
using LitMotion;
using LitMotion.Extensions;
using UnityEngine;

namespace _Root.Scripts.UIShowElements.Runtime
{
    public class MoveUITween : MonoBehaviour
    {
        public Vector3 startPosition;
        public Vector3 endPosition;
        public float duration;
        public Ease ease;
        public RectTransform rectTransform;

        public MotionHandle motionHandle;

        private void OnEnable()
        {
            motionHandle = LMotion.Create(startPosition, endPosition, duration).WithEase(ease)
                .BindToAnchoredPosition3D(rectTransform);
        }

        private void OnDestroy()
        {
            if(motionHandle.IsActive()) motionHandle.Cancel();
        }
    }
}
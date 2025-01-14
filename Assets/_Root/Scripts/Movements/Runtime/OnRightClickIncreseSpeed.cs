using System;
using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class OnRightClickIncreseSpeed : MonoBehaviour
    {
        public float speed = 3;
        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Time.timeScale = speed;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
            }else if (Input.GetMouseButtonUp(1))
            {
                Time.timeScale = 1;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
            }
        }
    }
}
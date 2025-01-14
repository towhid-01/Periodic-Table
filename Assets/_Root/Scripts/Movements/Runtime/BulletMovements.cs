using System;
using Pancake.Common;
using UnityEngine;

namespace _Root.Scripts.Movements.Runtime
{
    public class BulletMovements : MonoBehaviour
    {
       [SerializeField] private Rigidbody2D rb2D;
        public float bulletSpeed = 20f;
        private void OnEnable()
        {
            
            App.AddListener(EUpdateMode.FixedUpdate,OnUpdate);
        }

        private void OnDisable()
        {
            App.RemoveListener(EUpdateMode.FixedUpdate, OnUpdate);
        }
        
        private void OnUpdate()
        {
            rb2D.AddForce(rb2D.transform.up * bulletSpeed, ForceMode2D.Force);
        }
        
    }
}

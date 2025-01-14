using Pancake.Common;
using UnityEngine;
using App = Pancake.Common.App;

namespace _Root.Scripts.Gun_Mechanism.Runtime
{
    public class BulletSpawner : MonoBehaviour
    {
        public Transform firePoint; 
        public float speed = 10f;
        public GameObject bulletPrefab;

        private void OnEnable()
        {
            App.AddListener(EUpdateMode.Update, OnUpdate);
        }

        void OnDisable()
        {
            App.RemoveListener(EUpdateMode.Update, OnUpdate);
        }

        private void OnUpdate()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            }

        }
    }

   
}

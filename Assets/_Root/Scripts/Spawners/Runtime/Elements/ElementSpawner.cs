using _Root.Scripts.Elements.Runtime;  
using UnityEngine;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    public class ElementSpawner : MonoBehaviour
    {
        public ElementScriptableObject element;
        public SubatomicParticlesPrefabScriptableObject subatomicParticlesPrefabScriptableObject;  
        public Transform spawnerTransform;               
        public float spawnDistance = 10f;       

        void Start()
        {
            Instantiate(subatomicParticlesPrefabScriptableObject.neutrons,GetSpawnPosition(spawnDistance),Quaternion.identity);
            Instantiate(subatomicParticlesPrefabScriptableObject.protons ,GetSpawnPosition(spawnDistance),Quaternion.identity);
            Instantiate(subatomicParticlesPrefabScriptableObject.electrons,GetSpawnPosition(spawnDistance),Quaternion.identity);
        }
        
        Vector3 GetSpawnPosition(float distance)
        {
           
            float angle = Random.Range(0f, 2f * Mathf.PI); 

            // Convert polar coordinates (radius, angle) to Cartesian coordinates (x, y)
            float x = Mathf.Cos(angle) * distance;
            float y = Mathf.Sin(angle) * distance;

            
            return new Vector3(x, y, 0f) + spawnerTransform.position;
        }
    }
}

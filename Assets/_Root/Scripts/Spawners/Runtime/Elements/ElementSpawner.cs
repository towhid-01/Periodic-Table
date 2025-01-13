using _Root.Scripts.Elements.Runtime;  // Assuming this is the correct namespace for ElementScriptableObject
using UnityEngine;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    public class ElementSpawner : MonoBehaviour
    {
        public ElementScriptableObject element;
        public SubatomicParticlesPrefabScriptableObject subatomicParticlesPrefabScriptableObject;  
        public Transform nucleus;               
        public float spawnDistance = 10f;       

        void Start()
        {
            Instantiate(subatomicParticlesPrefabScriptableObject.neutrons);
            Instantiate(subatomicParticlesPrefabScriptableObject.protons);
            Instantiate(subatomicParticlesPrefabScriptableObject.electrons);
        }
        

        void SpawnParticle(GameObject particlePrefab)
        {
            Vector3 spawnPosition = GetSpawnPosition(spawnDistance);
            GameObject particle = Instantiate(particlePrefab, spawnPosition, Quaternion.identity);
            
        }

        Vector3 GetSpawnPosition(float distance)
        {
            // Generate a random angle for particle placement in a circular pattern around the nucleus
            float angle = Random.Range(0f, 2f * Mathf.PI); // Random angle between 0 and 2*PI (full circle)

            // Convert polar coordinates (radius, angle) to Cartesian coordinates (x, y)
            float x = Mathf.Cos(angle) * distance;
            float y = Mathf.Sin(angle) * distance;

            // Return the spawn position relative to the nucleus
            return new Vector3(x, y, 0f) + nucleus.position;
        }
    }
}

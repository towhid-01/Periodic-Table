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
        int protonCount;
        int neutronCount;
        int electroncount;

        private void OnEnable()
        {
            protonCount = element.protons;
            neutronCount = element.neutrons;
            electroncount = element.electrons;

            ParticleSpawnerforElectron();
            ParticleSpawnerforNeutron();
            ParticleSpawnerforProton();
        }

        void ParticleSpawnerforElectron()
        {
            if (electroncount > 0)
            {
                Instantiate(subatomicParticlesPrefabScriptableObject.electrons, GetSpawnPosition(spawnDistance), Quaternion.identity);
                protonCount -= 1;
                Invoke("ParticleSpawnerforElectron", Random.Range(2, 4));
            }
        }
        void ParticleSpawnerforNeutron()
        {
            if (neutronCount > 0)
            {
                Instantiate(subatomicParticlesPrefabScriptableObject.neutrons, GetSpawnPosition(spawnDistance), Quaternion.identity);
                neutronCount -= 1;
                Invoke("ParticleSpawnerforNeutron", Random.Range(2, 4));
            }
        }
        void ParticleSpawnerforProton()
        {
            if (protonCount > 0)
            {
                Instantiate(subatomicParticlesPrefabScriptableObject.protons, GetSpawnPosition(spawnDistance), Quaternion.identity);
                protonCount -= 1;
                Invoke("ParticleSpawnerforProton", Random.Range(2, 4));
            }
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

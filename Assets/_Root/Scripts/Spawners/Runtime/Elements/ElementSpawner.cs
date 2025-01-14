using _Root.Scripts.Elements.Runtime;
using Pancake.Common;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    public class ElementSpawner : MonoBehaviour
    {
        public SelectedElementsScriptableObject element;
        public SubatomicParticlesPrefabScriptableObject subatomicParticlesPrefabScriptableObject;
        public Transform spawnerTransform;
        public float spawnDistance = 10f;

        [MinMaxSlider(0, 10)] public Vector2 globalWaitingTime = new(0, 10);

        [SerializeField] private SubAtomicParticleConfig proton;
        [SerializeField] private SubAtomicParticleConfig neutron;
        [SerializeField] private SubAtomicParticleConfig electron;


        private void OnEnable()
        {
            proton.particleRemaining = element.selectedElement.protons;
            neutron.particleRemaining = element.selectedElement.neutrons;
            electron.particleRemaining = element.selectedElement.neutrons;
            
            App.AddListener(EUpdateMode.Update, OnUpdate);
        }

        private void OnDisable()
        {
            App.RemoveListener(EUpdateMode.Update, OnUpdate);
        }

        private void OnUpdate()
        {
            Spawn(proton, subatomicParticlesPrefabScriptableObject.proton);
            Spawn(electron, subatomicParticlesPrefabScriptableObject.electron);
            Spawn(neutron, subatomicParticlesPrefabScriptableObject.neutron);
        }

        private void Spawn(SubAtomicParticleConfig particleConfig, GameObject prefab)
        {
            if (particleConfig.TrySpawn(globalWaitingTime, spawnerTransform.position, spawnDistance, out var position))
            {
                Instantiate(prefab, position, Quaternion.identity);
            }
        }
    }
}
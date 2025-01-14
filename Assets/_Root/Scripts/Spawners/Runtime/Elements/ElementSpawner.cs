using _Root.Scripts.Elements.Runtime;
using Pancake.Common;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    public class ElementSpawner : MonoBehaviour
    {
        [FormerlySerializedAs("element")] public SelectedElementsScriptableObject selectedElementsScriptableObject;
        public SubatomicParticlesPrefabScriptableObject subatomicParticlesPrefabScriptableObject;
        public Transform spawnerTransform;
        public float spawnDistance = 10f;
        public int chanceMultipler = 3;

        [MinMaxSlider(0, 10)] public Vector2 globalWaitingTime = new(0, 10);

        [SerializeField] private SubAtomicParticleConfig proton;
        [SerializeField] private SubAtomicParticleConfig neutron;
        [SerializeField] private SubAtomicParticleConfig electron;


        private void OnEnable()
        {
            var elementScriptableObject = selectedElementsScriptableObject.GetCurrentElement();
            proton.particleRemaining = elementScriptableObject.protons * chanceMultipler;
            neutron.particleRemaining = elementScriptableObject.neutrons * chanceMultipler;
            electron.particleRemaining = elementScriptableObject.electrons * chanceMultipler;

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
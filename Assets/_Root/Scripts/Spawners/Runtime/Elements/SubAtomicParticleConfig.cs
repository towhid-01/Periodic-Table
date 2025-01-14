using System;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    [Serializable]
    public struct SubAtomicParticleConfig
    {
        [SerializeField] [DisableInEditorMode] public int particleCount;
        [MinMaxSlider(0, 10)] public Vector2 delayForParticle;
        [SerializeField] [DisableInEditorMode] private float particleWaitingTime;
        [SerializeField] [DisableInEditorMode] private bool particleSpawned;

        public bool TrySpawn(Vector3 globalWaitingTime, Vector3 spawnerPosition, float distance, out Vector3 position)
        {
            position = new Vector3();
            particleWaitingTime += Time.deltaTime;
            if (delayForParticle.x < particleWaitingTime && particleWaitingTime < delayForParticle.y)
            {
                if (particleSpawned == false)
                {
                    particleSpawned = true;
                    position = GetSpawnPosition(distance, spawnerPosition);
                    return true;
                }
            }
            else if (globalWaitingTime.y <= particleWaitingTime)
            {
                particleWaitingTime = globalWaitingTime.x;
                particleSpawned = false;
            }

            return false;
        }

        Vector3 GetSpawnPosition(float distance, Vector3 spawnerPosition)
        {
            float angle = Random.Range(0f, 2f * Mathf.PI);
            // Convert polar coordinates (radius, angle) to Cartesian coordinates (x, y)
            float x = Mathf.Cos(angle) * distance;
            float y = Mathf.Sin(angle) * distance;
            return new Vector3(x, y, 0f) + spawnerPosition;
        }
    }
}
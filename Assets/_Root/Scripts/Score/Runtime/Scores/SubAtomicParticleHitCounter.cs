using UnityEngine;

namespace _Root.Scripts.Score.Runtime.Scores
{
    public class SubAtomicParticleHitCounter : MonoBehaviour
    {
        [SerializeField] private int protonCount;
        [SerializeField] private int neutronCount;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Proton"))
            {
                protonCount += 1;
                Debug.Log($"Proton -> {protonCount}");
            }

            if (other.gameObject.CompareTag("Neutron"))
            {
                neutronCount += 1;
                Debug.Log($"Neutron -> {neutronCount}");
            }
        }
    }
}




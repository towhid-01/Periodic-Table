using UnityEngine;

namespace _Root.Scripts.Gun_Mechanism.Runtime
{
    public class OnCollisionDestroy : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(this.gameObject);
        }
    }
}

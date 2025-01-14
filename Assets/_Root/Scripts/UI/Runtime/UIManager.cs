using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Root.Scripts.UI.Runtime
{
    public class UIManager : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene(1);
        }

        public void PeriodicTable()
        {
            SceneManager.LoadScene(2);
        }
        
        public void Quit()
        {
            Application.Quit();
        }
    }
}

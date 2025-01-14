using UnityEngine;

namespace _Root.Scripts.Score.Runtime
{
    [CreateAssetMenu(fileName = "OnDeadIncreseCounter", menuName = "Scriptable/OnDeadIncreseCounter", order = 0)]
    public class CounterScriptableObject : ScriptableObject
    {
        public int count;
    }
}
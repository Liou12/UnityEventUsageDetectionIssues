using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class UnityEventHolderPrefab : MonoBehaviour
    {
        [SerializeField] private UnityEvent _eventInPrefab;
        [SerializeField] private UnityEvent _eventInPrefabOverride;

        /// <summary>
        /// It works fine if the assigned Method for the plain UnityEvent is part of a prefab
        /// </summary>
        public void PrefabMethodIsDetected()
        {
        }

        /// <summary>
        /// If the assigned Method is not part of the prefab, but an override the method appears green to me(Shows that is not unused),
        /// but the actual usage is not shown and refactoring does not work
        /// </summary>
        public void PrefabOverrideMethodIsNotDetected()
        {
        }
    }
}
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class UnityEventHolder : MonoBehaviour
    {
        [SerializeField] private UnityEvent _eventPlain;
        [SerializeField] private List<UnityEvent> _eventList;

        [SerializeField] private SerializableUnityEventHolder _serializableUnityEventHolder;

        /// <summary>
        /// Shows usage + can refactor
        /// </summary>
        public void PlainMethodIsDetected()
        {
        }

        /// <summary>
        /// Does not show usage(Greyed out) + cannot refactor
        /// </summary>
        public void ListMethodIsNotDetected()
        {
        }

        /// <summary>
        /// Does not show usage(Greyed out) + cannot refactor
        /// </summary>
        public void SerializableMethodIsNotDetected()
        {
        }
    }
}
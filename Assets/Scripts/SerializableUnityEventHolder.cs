using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    [Serializable]
    public class SerializableUnityEventHolder
    {
        [SerializeField] private UnityEvent _eventInSerializable;
    }
}
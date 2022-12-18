using UnityEngine;

namespace ComponentBasedUI.EventListeners
{
    public enum ListenerType
    {
        [InspectorName("Awake, OnDestroy")] AwakeDestroy = 0,
        [InspectorName("OnEnable, OnDisable")] EnableDisable = 1,
        [InspectorName("Start, OnDestroy")] StartDestroy = 2,
    }
}

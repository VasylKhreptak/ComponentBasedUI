using ComponentBasedUI.EventListeners;
using UnityEngine;

public class TEST : MonoEventListener
{
    protected override void OnEventFired()
    {
        Debug.Log("Event Fired!");
    }
}

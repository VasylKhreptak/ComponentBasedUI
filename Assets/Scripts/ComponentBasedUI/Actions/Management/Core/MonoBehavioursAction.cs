using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Core
{
    public abstract class MonoBehavioursAction : Action
    {
        [Header("References")]
        [SerializeField] protected MonoBehaviour[] _scripts;
    }
}

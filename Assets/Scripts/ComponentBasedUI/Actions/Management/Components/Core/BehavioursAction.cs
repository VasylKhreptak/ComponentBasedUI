using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Components.Core
{
    public abstract class BehavioursAction : Action
    {
        [Header("References")]
        [SerializeField] protected Behaviour[] _scripts;
    }
}

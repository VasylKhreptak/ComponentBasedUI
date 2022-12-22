using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Scripts.Core
{
    public abstract class ScriptsAction : Action
    {
        [Header("References")]
        [SerializeField] protected Behaviour[] _scripts;
    }
}
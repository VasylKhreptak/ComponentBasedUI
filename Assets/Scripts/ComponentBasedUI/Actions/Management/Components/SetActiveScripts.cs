using ComponentBasedUI.Actions.Management.Components.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Components
{
    public class SetActiveScripts : BehavioursAction
    {
        [Header("Preferences")]
        [SerializeField] private bool _enabled;

        public override void Do()
        {
            foreach (var script in _scripts)
            {
                script.enabled = _enabled;
            }
        }
    }
}

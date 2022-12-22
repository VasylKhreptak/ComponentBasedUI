using ComponentBasedUI.Actions.Management.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management
{
    public class SetActiveScripts : MonoBehavioursAction
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

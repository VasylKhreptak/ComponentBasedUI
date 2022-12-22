using ComponentBasedUI.Actions.Management.Scripts.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Scripts
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

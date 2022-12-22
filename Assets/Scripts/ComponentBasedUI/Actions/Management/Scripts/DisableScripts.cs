using ComponentBasedUI.Actions.Management.Scripts.Core;

namespace ComponentBasedUI.Actions.Management.Scripts
{
    public class DisableScripts : BehavioursAction
    {
        public override void Do()
        {
            foreach (var script in _scripts)
            {
                script.enabled = false;
            }
        }
    }
}
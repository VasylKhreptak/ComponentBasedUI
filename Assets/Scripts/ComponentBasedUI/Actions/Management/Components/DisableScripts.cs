using ComponentBasedUI.Actions.Management.Components.Core;

namespace ComponentBasedUI.Actions.Management.Components
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

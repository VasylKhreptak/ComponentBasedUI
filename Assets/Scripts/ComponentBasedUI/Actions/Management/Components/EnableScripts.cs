using ComponentBasedUI.Actions.Management.Components.Core;

namespace ComponentBasedUI.Actions.Management.Components
{
    public class EnableScripts : BehavioursAction
    {
        public override void Do()
        {
            foreach (var script in _scripts)
            {
                script.enabled = true;
            }
        }
    }
}

using ComponentBasedUI.Actions.Management.Core;

namespace ComponentBasedUI.Actions.Management
{
    public class EnableScripts : MonoBehavioursAction
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

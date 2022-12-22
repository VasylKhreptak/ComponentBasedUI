using ComponentBasedUI.Actions.Management.Core;

namespace ComponentBasedUI.Actions.Management
{
    public class DisableScripts : MonoBehavioursAction
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

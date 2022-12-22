using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnUpdateAction : ActionContainer
    {
        #region MonoBehaviour
        
        private void Update()
        {
            _action.Do();
        }

        #endregion
    }
}

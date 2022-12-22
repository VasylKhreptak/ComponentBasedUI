using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnFixedUpdateAction : ActionContainer
    {
        #region MonoBehaviour
        
        private void FixedUpdate()
        {
            _action.Do();
        }

        #endregion
    }
}

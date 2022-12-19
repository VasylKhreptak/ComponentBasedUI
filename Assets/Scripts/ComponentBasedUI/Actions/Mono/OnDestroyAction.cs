using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnDestroyAction : ActionContainer
    {
        #region MonoBehaviour
        
        private void OnDestroy()
        {
            _action.Do();
        }

        #endregion
    }
}

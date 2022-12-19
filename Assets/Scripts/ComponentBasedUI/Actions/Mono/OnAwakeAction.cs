using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnAwakeAction : ActionContainer
    {
        #region MonoBehaviour
        
        private void Awake()
        {
            _action.Do();
        }

        #endregion
    }
}

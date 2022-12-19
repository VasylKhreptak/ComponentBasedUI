using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnEnableAction : ActionContainer
    {
        #region MonoBehaviour

        private void OnEnable()
        {
            _action.Do();
        }

        #endregion
    }
}

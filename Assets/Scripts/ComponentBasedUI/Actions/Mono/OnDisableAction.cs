using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnDisableAction : ActionContainer
    {
        #region MonoBehaviour

        private void OnDisable()
        {
            _action.Do();
        }

        #endregion
    }
}

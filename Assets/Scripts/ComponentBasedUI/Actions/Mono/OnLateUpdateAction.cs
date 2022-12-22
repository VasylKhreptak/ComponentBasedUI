using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnLateUpdateAction : ActionContainer
    {
        #region MonoBehaviour

        private void LateUpdate()
        {
            _action.Do();
        }

        #endregion
    }
}

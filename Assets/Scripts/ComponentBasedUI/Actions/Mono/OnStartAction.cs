using ComponentBasedUI.Actions.Mono.Core;

namespace ComponentBasedUI.Actions.Mono
{
    public class OnStartAction : ActionContainer
    {
        #region MonoBehaviour

        private void Start()
        {
            _action.Do();
        }

        #endregion
    }
}

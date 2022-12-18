using ComponentBasedUI.MonoEvents.Core;

namespace ComponentBasedUI.Events.Mono
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnEnableEvent : MonoEvent
    {
        #region MonoBehaviour

        private void OnEnable()
        {
            Invoke();
        }

        #endregion
    }
}
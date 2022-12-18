using ComponentBasedUI.MonoEvents.Core;

namespace ComponentBasedUI.Events.Mono
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnDisableEvent : MonoEvent
    {
        #region MonoBehaviour

        private void OnDisable()
        {
            Invoke();
        }

        #endregion
    }
}

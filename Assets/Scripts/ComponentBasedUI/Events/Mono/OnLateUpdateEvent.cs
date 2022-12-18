using ComponentBasedUI.MonoEvents.Core;

namespace ComponentBasedUI.Events.Mono
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnLateUpdateEvent : MonoEvent
    {
        #region MonoBehaviour

        private void LateUpdate()
        {
            Invoke();
        }

        #endregion
    }
}

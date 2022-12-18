using ComponentBasedUI.MonoEvents.Core;

namespace ComponentBasedUI.Events.Mono
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnFixedUpdateEvent : MonoEvent
    {
        #region MonoBehaviour

        private void FixedUpdate()
        {
            Invoke();
        }

        #endregion
    }
}

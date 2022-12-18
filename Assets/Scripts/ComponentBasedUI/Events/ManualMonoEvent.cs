using ComponentBasedUI.MonoEvents.Core;
using NaughtyAttributes;

namespace ComponentBasedUI.Events
{
    public class ManualMonoEvent : MonoEvent
    {
        [Button("Invoke")]
        public new void Invoke() => base.Invoke();
    }
}

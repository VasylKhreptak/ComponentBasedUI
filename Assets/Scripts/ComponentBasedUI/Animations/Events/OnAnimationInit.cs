using ComponentBasedUI.Animations.Core;
using ComponentBasedUI.EventListeners.Core;
using UnityEngine;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationInit : EventListener
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;
        
        protected override void AddListener()
        {
            _animation.onInit += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.onInit -= Invoke;
        }
    }
}

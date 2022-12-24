using CBA.EventListeners.Core;
using NaughtyAttributes;
using UnityEngine;
using Animation = CBA.Animations.Core.Animation;

namespace CBA.Animations.Events
{
    public class OnAnimationInit : EventListener
    {
        [Header("References")]
        [Required, SerializeField] private Animation _animation;
        
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

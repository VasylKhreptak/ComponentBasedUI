using DG.Tweening;
using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationDelay : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        [Header("Preferences")]
        [SerializeField] private float _delay;
        
        public override void Do()
        {
            _animation.GetTween().SetDelay(_delay);
        }
    }
}

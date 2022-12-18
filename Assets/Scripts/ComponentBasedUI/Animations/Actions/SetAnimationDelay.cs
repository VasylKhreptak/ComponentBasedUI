using DG.Tweening;
using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;
using Animation = ComponentBasedUI.Animations.Core.Animation;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationDelay : Action
    {
        [Header("References")]
        [SerializeField] private Animation _animation;

        [Header("Preferences")]
        [SerializeField] private float _delay;
        
        public override void Do()
        {
            _animation.GetTween().SetDelay(_delay);
        }
    }
}

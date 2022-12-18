using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationDelay : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private float _delay;
        
        public override void Do()
        {
            _animation.GetTween().SetDelay(_delay);
        }
    }
}

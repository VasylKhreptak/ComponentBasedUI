using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationID : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        [Header("Preferences")]
        [SerializeField] private int _id;
        
        public override void Do()
        {
            _animation.GetTween().SetId(_id);
        }
    }
}

using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayForwardAnimation : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        public override void Do()
        {
            _animation.GetTween().PlayForward();
        }
    }
}

using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;
using Animation = ComponentBasedUI.Animations.Core.Animation;

namespace ComponentBasedUI.Animations.Actions
{
    public class CompleteAnimation : Action
    {
        [Header("References")]
        [SerializeField] private Animation _animation;

        public override void Do()
        {
            _animation.GetTween().Complete();
        }
    }
}

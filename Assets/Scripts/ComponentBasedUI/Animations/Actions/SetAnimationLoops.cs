using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationLoops : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        [Header("Preferences")]
        [SerializeField] private int _loops;

        public override void Do()
        {
            _animation.GetTween().SetLoops(_loops);
        }
    }
}

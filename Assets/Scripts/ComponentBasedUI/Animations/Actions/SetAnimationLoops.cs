using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationLoops : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private int _loops;

        public override void Do()
        {
            _animation.GetTween().SetLoops(_loops);
        }
    }
}

using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationUpdateType : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private UpdateType _updateType;
        
        public override void Do()
        {
            _animation.GetTween().SetUpdate(_updateType);
        }
    }
}

using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationID : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private int _id;
        
        public override void Do()
        {
            _animation.GetTween().SetId(_id);
        }
    }
}

using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation.Core
{
    public abstract class DirectionMoveAnimation : MoveAnimationCore
    {
        [Header("Preferences")]
        [SerializeField] protected float _from;
        [SerializeField] protected float _to;
    }
}

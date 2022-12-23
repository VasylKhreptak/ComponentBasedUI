using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation.Core
{
    public abstract class DirectionMoveAnimation : TransformAnimation
    {
        [Header("Move Preferences")]
        [SerializeField] protected float _from;
        [SerializeField] protected float _to;
    }
}

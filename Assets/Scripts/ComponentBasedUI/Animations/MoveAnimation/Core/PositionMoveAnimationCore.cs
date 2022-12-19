using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation.Core
{
    public abstract class PositionMoveAnimationCore : MoveAnimationCore
    {
        [Header("Move Preferences")]
        [SerializeField] protected Vector3 _startPosition;
        [SerializeField] protected Vector3 _targetPosition;
    }
}

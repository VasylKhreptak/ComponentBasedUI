using UnityEngine;

namespace CBA.Animations.MoveAnimation.Core
{
    public abstract class PositionMoveAnimationCore : TransformAnimation
    {
        [Header("Move Preferences")]
        [SerializeField] protected Vector3 _startPosition;
        [SerializeField] protected Vector3 _targetPosition;
    }
}

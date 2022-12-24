using UnityEngine;

namespace CBA.Animations.MoveAnimation.Core
{
    public abstract class PositionMoveAnimation : TransformAnimation
    {
        [Header("Move Preferences")]
        [SerializeField] protected Vector3 _startPosition;
        [SerializeField] protected Vector3 _targetPosition;
    }
}

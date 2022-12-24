using UnityEngine;

namespace CBA.Animations.Transform.Move.Core
{
    public abstract class PositionMoveAnimation : TransformAnimation
    {
        [Header("Move Preferences")]
        [SerializeField] protected Vector3 _startPosition;
        [SerializeField] protected Vector3 _targetPosition;
    }
}

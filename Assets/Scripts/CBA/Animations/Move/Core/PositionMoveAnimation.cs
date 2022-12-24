using UnityEngine;

namespace CBA.Animations.Move.Core
{
    public abstract class PositionMoveAnimation : TransformAnimation
    {
        [Header("Move Preferences")]
        [SerializeField] protected Vector3 _startPosition;
        [SerializeField] protected Vector3 _targetPosition;
    }
}

using CBA.Animations.Transform.Core;
using UnityEngine;

namespace CBA.Animations.Transform.Move.Core
{
    public abstract class MoveAnimationCore : TransformAnimationCore
    {
        [Header("Move Preferences")]
        [SerializeField] protected Vector3 _startPosition;
        [SerializeField] protected Vector3 _targetPosition;
    }
}

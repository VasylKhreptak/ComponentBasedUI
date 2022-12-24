using CBA.Animations.Transform.Move.Core;
using UnityEngine;

namespace CBA.Animations.Transform.Rotate.Core
{
    public abstract class AngleAnimation : TransformAnimation
    {
        [Header("Rotate Preferences")]
        [SerializeField] protected Vector3 _startAngle;
        [SerializeField] protected Vector3 _targetAngle;
    }
}

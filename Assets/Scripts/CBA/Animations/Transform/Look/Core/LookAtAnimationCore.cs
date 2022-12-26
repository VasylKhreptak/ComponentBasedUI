using CBA.Animations.Transform.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Transform.Look.Core
{
    public abstract class LookAtAnimationCore: TransformAnimationCore
    {
        [Header("Look At Preferences")]
        [Required, SerializeField] protected PositionProvider.Core.PositionProvider _starTarget;
        [Required, SerializeField] protected PositionProvider.Core.PositionProvider _endTarget;
        [SerializeField] protected DG.Tweening.AxisConstraint _axisConstraint = DG.Tweening.AxisConstraint.None;
        [SerializeField] protected Vector3 _up = Vector3.up;
    }
}

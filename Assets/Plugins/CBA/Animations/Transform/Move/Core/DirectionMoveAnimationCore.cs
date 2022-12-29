using CBA.Animations.Transform.Core;
using UnityEngine;

namespace CBA.Animations.Transform.Move.Core
{
    public abstract class DirectionMoveAnimationCore : TransformAnimationCore
    {
        [Header("Move Preferences")]
        [SerializeField] protected float _from;
        [SerializeField] protected float _to;

        [Header("Snapping")]
        [SerializeField] protected bool _snapping;

        protected override void MoveToStartState()
        {
            MoveTo(_from);
        }

        protected override void MoveToEndState()
        {
            MoveTo(_to);
        }

        protected abstract void MoveTo(float axisPosition);
    }
}

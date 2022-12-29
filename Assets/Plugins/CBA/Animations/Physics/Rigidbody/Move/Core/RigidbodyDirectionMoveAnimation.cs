using UnityEngine;

namespace CBA.Animations.Physics.Rigidbody.Move.Core
{
    public abstract class RigidbodyDirectionMoveAnimation : RigidbodyMoveAnimationCore
    {
        [Header("Move Preferences")]
        [SerializeField] protected float _from;
        [SerializeField] protected float _to;

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

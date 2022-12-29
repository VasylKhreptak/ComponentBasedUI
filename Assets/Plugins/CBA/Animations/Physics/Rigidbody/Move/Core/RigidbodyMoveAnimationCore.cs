using CBA.Animations.Physics.Rigidbody.Core;
using UnityEngine;

namespace CBA.Animations.Physics.Rigidbody.Move.Core
{
    public abstract class RigidbodyMoveAnimationCore : RigidbodyAnimationCore
    {
        [Header("Snapping")]
        [SerializeField] protected bool _snapping;
    }
}

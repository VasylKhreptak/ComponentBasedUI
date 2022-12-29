using CBA.Animations.Physics.Rigidbody2D.Core;
using UnityEngine;

namespace CBA.Animations.Physics.Rigidbody2D.Move.Core
{
    public abstract class Rigidbody2DMoveAnimationCore : Rigidbody2DAnimationCore
    {
        [Header("Snapping")]
        [SerializeField] protected bool _snapping;
    }
}

using CBA.Animations.Core;
using UnityEngine;

namespace CBA.Animations.Physics.Rigidbody.Core
{
    public abstract class RigidbodyAnimationCore : AnimationCore
    {
        [Header("References")]
        [SerializeField] protected UnityEngine.Transform _transform;
        [SerializeField] protected UnityEngine.Rigidbody _rigidbody;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<UnityEngine.Transform>();
            _rigidbody ??= GetComponent<UnityEngine.Rigidbody>();
        }

        #endregion
    }
}

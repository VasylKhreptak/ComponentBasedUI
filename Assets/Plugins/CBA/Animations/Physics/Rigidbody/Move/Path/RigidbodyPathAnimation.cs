using CBA.Animations.Transform.Move.Path;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Physics.Rigidbody.Move.Path
{
    public class RigidbodyPathAnimation : PathAnimation
    {
        [Header("Rigidbody")]
        [SerializeField] private UnityEngine.Rigidbody _rigidbody;

        #region MonoBehaviour

        protected override void OnValidate()
        {
            base.OnValidate();

            _rigidbody ??= GetComponent<UnityEngine.Rigidbody>();
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _rigidbody.DOPath(Extensions.PositionProvider.ToVector3Array(_positionProviders), _duration, _pathType, _pathMode, _resolution);
        }

        protected override Tween CreateBackwardTween()
        {
            return _rigidbody.DOPath(Extensions.PositionProvider.ToVector3Array(GetReversedPath()), _duration, _pathType, _pathMode, _resolution);
        }
    }
}

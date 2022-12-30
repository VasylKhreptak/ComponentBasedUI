﻿using CBA.Animations.Transform.Move.Path;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Physics.Rigidbody2D.Move.Path
{
    public class Rigidbody2DLocalPathAnimation : LocalPathAnimation
    {
        [Header("Rigidbody")]
        [SerializeField] private UnityEngine.Rigidbody2D _rigidbody2D;

        #region MonoBehaviour

        protected override void OnValidate()
        {
            base.OnValidate();

            _rigidbody2D ??= GetComponent<UnityEngine.Rigidbody2D>();
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _rigidbody2D.DOLocalPath(Extensions.PositionProvider.ToVector2Array(_positionProviders), _duration, _pathType, _pathMode, _resolution);
        }

        protected override Tween CreateBackwardTween()
        {
            return _rigidbody2D.DOLocalPath(Extensions.PositionProvider.ToVector2Array(GetReversedPath()), _duration, _pathType, _pathMode, _resolution);
        }
    }
}

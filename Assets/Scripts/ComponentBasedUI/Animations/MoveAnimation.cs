using DG.Tweening;
using UnityEngine;
using Animation = ComponentBasedUI.Animations.Core.Animation;

namespace ComponentBasedUI.Animations
{
    public class MoveAnimation : Animation
    {
        [Header("References")]
        [SerializeField] private Transform _transform;

        [Header("Preferences")]
        [SerializeField] private Vector3 _startPosition;
        [SerializeField] private Vector3 _targetPosition;
        [SerializeField] private float _duration;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<Transform>();

            if (_startPosition == Vector3.zero)
            {
                _startPosition = _transform.position;
            }
        }

        #endregion
        public override void Init()
        {
            _tween = _transform.DOMove(_targetPosition, _duration);
        }
        public override void PlayFromStart()
        {
            _transform.position = _startPosition;
            _tween.Play();
        }

        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            Gizmos.color = Color.green;
            Gizmos.DrawSphere(_targetPosition, 0.1f);
            Gizmos.DrawLine(_transform.position, _targetPosition);
        }
    }
}

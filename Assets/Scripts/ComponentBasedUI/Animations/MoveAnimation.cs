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
        [SerializeField] private Vector3 _targetPosition;
        [SerializeField] private float _duration;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<Transform>();
        }

        #endregion
        public override Tween Init()
        {
            _tween = _transform.DOMove(_targetPosition, _duration);

            return _tween;
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

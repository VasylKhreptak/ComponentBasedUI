using ComponentBasedUI.Actions.Management.Transform.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Transform.General
{
    public class LookAtTransform : TransformAction
    {
        [Header("Preferences")]
        [Required, SerializeField] private UnityEngine.Transform _target;
        [SerializeField] private Vector3Int _upwards = Vector3Int.up;
        [SerializeField] private Vector3 _rotationOffset;

        #region MonoBehaviour

        protected override void OnValidate()
        {
            base.OnValidate();

            _upwards = Extensions.Vector3Int.ClampComponents1BothSign(_upwards);
        }

        #endregion

        public override void Do()
        {
            _transform.rotation = Quaternion.Euler(GetEvaluatedLookRotation());
        }

        #region Editor

        private Vector3 GetLookDirection()
        {
            return (_target.position - _transform.position).normalized;
        }

        private Vector3 GetLookRotation()
        {
            Vector3 rawRotation = Quaternion.LookRotation(GetLookDirection(), _upwards).eulerAngles;
            return (Quaternion.Euler(rawRotation) * Quaternion.Euler(_rotationOffset)).eulerAngles;
        }

        private Vector3 GetEvaluatedLookRotation()
        {
            return Extensions.Vector3.ReplaceWithByAxes(_transform.rotation.eulerAngles, GetLookRotation(), _axes);
        }

#if UNITY_EDITOR

        [ShowNonSerializedField] private Vector3 _startRotation;
        [ShowNonSerializedField] private bool _movedToStart;
        [ShowNonSerializedField] private bool _movedToEnd;

        [Button("Look At Target")]
        private void LookAtTarget()
        {
            if (_movedToEnd) return;

            _startRotation = _transform.rotation.eulerAngles;
            _transform.rotation = Quaternion.Euler(GetEvaluatedLookRotation());

            _movedToEnd = true;
            _movedToStart = false;
        }

        [Button("Restore Rotation")]
        private void RestoreRotation()
        {
            if (_movedToStart || _movedToEnd == false) return;

            _transform.rotation = Quaternion.Euler(_startRotation);

            _movedToStart = true;
            _movedToEnd = false;
        }

#endif

        #endregion

    }
}

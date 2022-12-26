using UnityEngine;

namespace CBA.Animations.Transform.Look.PositionProvider
{
    public class TransformPositionProvider : Core.PositionProvider
    {
        [Header("References")]
        [SerializeField] private UnityEngine.Transform _transform;

        public override Vector3 position
        {
            get => _transform.position;
            set => _transform.position = value;
        }

        #region MonoBehavioue

        private void OnValidate()
        {
            _transform ??= GetComponent<UnityEngine.Transform>();
        }

        #endregion

    }
}

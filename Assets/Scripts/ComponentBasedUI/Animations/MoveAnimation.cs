using UnityEngine;
using Animation = ComponentBasedUI.Animations.Core.Animation;

public class MoveAnimation : Animation
{
   [Header("References")]
   [SerializeField] private Transform _transform;

   [Header("Preferences")]
   [SerializeField] private bool _fromStart = true;
   [SerializeField] private Vector3 _startPosition;
   [SerializeField] private Vector3 _targetPosition;
   [SerializeField] private float _duration;
   
   #region MonoBehaviour

   private void OnValidate()
   {
      _transform ??= GetComponent<Transform>();
   }

   #endregion
}

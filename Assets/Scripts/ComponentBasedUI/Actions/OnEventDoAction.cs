using ComponentBasedUI.MonoEvents;
using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;

public class OnEventDoAction : MonoBehaviour
{
   [Header("References")]
   [SerializeField] private Action _action;

   [Header("Events")]
   [SerializeField] private MonoEvent _monoEvent;

   #region MonoBehaviour

   private void OnValidate()
   {
      _monoEvent ??= GetComponent<MonoEvent>();
   }

   private void OnEnable()
   {
      _monoEvent.onMonoCall += _action.Do;
   }

   private void OnDisable()
   {
      _monoEvent.onMonoCall -= _action.Do;
   }

   #endregion
}

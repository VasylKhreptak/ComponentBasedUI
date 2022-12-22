using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Console
{
    public class ConsoleLog : Action
    {
        [Header("Preferences")]
        [SerializeField] private string _message;

        public override void Do()
        {
            Debug.Log(_message);
        }
    }
}

using ComponentBasedUI.Actions.Management.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management
{
    public class SetActiveObjects : GameObjectsAction
    {
        [Header("Preferences")]
        [SerializeField] private bool _active;
        
        public override void Do()
        {
            foreach (var go in _gameObjects)
            {
                go.SetActive(_active);
            }
        }
    }
}

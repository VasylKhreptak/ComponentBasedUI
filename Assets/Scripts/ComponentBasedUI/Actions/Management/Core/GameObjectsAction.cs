using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Core
{
    public abstract class GameObjectsAction : Action
    {
        [Header("References")]
        [SerializeField] protected GameObject[] _gameObjects;
    }
}

using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.GameObjects.Core
{
    public abstract class GameObjectsAction : Action
    {
        [Header("References")]
        [SerializeField] protected GameObject[] _gameObjects;
    }
}

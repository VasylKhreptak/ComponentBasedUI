using ComponentBasedUI.Actions.Management.Core;

namespace ComponentBasedUI.Actions.Management
{
    public class DisableObjects : GameObjectsAction
    {
        public override void Do()
        {
            foreach (var go in _gameObjects)
            {
                go.SetActive(false);
            }
        }
    }
}

using ComponentBasedUI.Actions.Management.GameObjects.Core;

namespace ComponentBasedUI.Actions.Management.GameObjects
{
    public class EnableObjects : GameObjectsAction
    {
        public override void Do()
        {
            foreach (var go in _gameObjects)
            {
                go.SetActive(true);
            }
        }
    }
}

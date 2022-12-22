using ComponentBasedUI.Actions.Management.Scene.Core;
using UnityEngine.SceneManagement;

namespace ComponentBasedUI.Actions.Management.Scene
{
    public class LoadScene : SceneAction
    {
        public override void Do()
        {
            SceneManager.LoadScene(_scene);
        }
    }
}

using ComponentBasedUI.Actions.Core;
using UnityEngine.SceneManagement;

namespace ComponentBasedUI.Actions.Management.Scene
{
    public class ReloadScene : Action
    {
        public override void Do()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

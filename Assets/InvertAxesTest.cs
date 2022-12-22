using NaughtyAttributes;
using TMPro;
using UnityEngine;

public class InvertAxesTest : MonoBehaviour
{
   [Button("Test")]
   private void Test()
   {
      Debug.Log(ComponentBasedUI.Extensions.Vector3.ReplaceWithByAxes(transform.position, Vector3.zero, new Vector3Int(1, 1, 1)));
      Debug.Log(ComponentBasedUI.Extensions.Vector3.ReplaceWithByAxes(transform.position, Vector3.zero, new Vector3Int(1, 0, 1)));
      Debug.Log(ComponentBasedUI.Extensions.Vector3.ReplaceWithByAxes(transform.position, Vector3.zero, new Vector3Int(1, 1, 0)));
      Debug.Log(ComponentBasedUI.Extensions.Vector3.ReplaceWithByAxes(transform.position, Vector3.zero, new Vector3Int(0, 1, 1)));
      Debug.Log(ComponentBasedUI.Extensions.Vector3.ReplaceWithByAxes(transform.position, Vector3.zero, new Vector3Int(0, 0, 1)));
      Debug.Log(ComponentBasedUI.Extensions.Vector3.ReplaceWithByAxes(transform.position, Vector3.zero, new Vector3Int(1, 0, 0)));
   }
}

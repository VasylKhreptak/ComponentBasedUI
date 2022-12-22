namespace ComponentBasedUI.Extensions
{
    public static class Vector3
    {
        public static UnityEngine.Vector3 ReplaceWithByAxes(UnityEngine.Vector3 @in, UnityEngine.Vector3 replaceWith, UnityEngine.Vector3Int axes)
        {
            return UnityEngine.Vector3.Scale(@in, Vector3Int.InverseAxes(axes)) + UnityEngine.Vector3.Scale(replaceWith, axes);
        }
    }
}

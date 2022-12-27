using UnityEngine;

namespace CBA.Extensions
{
    public static class Transform
    {
        public static UnityEngine.Transform[] GetChildren(this UnityEngine.Transform transform)
        {
            UnityEngine.Transform[] children = new UnityEngine.Transform[transform.childCount];

            for (int i = 0; i < children.Length; i++)
            {
                children[i] = transform.GetChild(i);
            }

            return children;
        }

        public static void DestroyChildren(this UnityEngine.Transform transform)
        {
            UnityEngine.Transform[] children = transform.GetChildren();

            foreach (var child in children)
            {
                Object.Destroy(child.gameObject);
            }
        }

        public static void DestroyImmediateChildren(this UnityEngine.Transform transform)
        {
            UnityEngine.Transform[] children = transform.GetChildren();

            foreach (var child in children)
            {
                Object.DestroyImmediate(child.gameObject);
            }
        }
    }
}

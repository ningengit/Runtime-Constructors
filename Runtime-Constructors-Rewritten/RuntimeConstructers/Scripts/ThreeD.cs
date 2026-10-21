using TMPro;
using UnityEngine;

namespace RuntimeConstructers
{
    public static class ThreeD
    {
        public static GameObject TextTMPro(string name, Vector3 position, string text)
        {
            var go = new GameObject(name, typeof(TextMeshPro));
            go.GetComponent<TextMeshPro>().text = text;
            go.transform.position = position;
            return go;
        }

        public static GameObject TextMesh(string name, Vector3 position, string text)
        {
            var go = new GameObject(name, typeof(TextMesh));
            go.GetComponent<TextMesh>().text = text;
            go.GetComponent<MeshRenderer>().allowOcclusionWhenDynamic = false;
            go.transform.position = position;
            return go;
        }
    }
}

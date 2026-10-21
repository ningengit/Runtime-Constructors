using System.IO;
using System.Text;
using UnityEngine;

namespace RuntimeConstructers
{
    /// <summary>
    /// Exports a GameObject's hierarchy and component summary to a file at runtime.
    /// </summary>
    public class SaveGameObject : MonoBehaviour
    {
        public enum SaveAs
        {
            UnityScene,
            Prefab
        }

        public SaveAs saveAs = SaveAs.Prefab;
        public GameObject gameobject;

        private void Start()
        {
            GameObject target = gameobject != null ? gameobject : gameObject;
            SaveHierarchyReport(target, saveAs);
        }

        public static string SaveHierarchyReport(GameObject target, SaveAs format = SaveAs.Prefab)
        {
            if (target == null) return null;

            string extension = format == SaveAs.Prefab ? ".prefab.txt" : ".unity.txt";
            string filePath = Path.Combine(Application.persistentDataPath, target.name + extension);

            var sb = new StringBuilder();
            sb.AppendLine($"# Hierarchy Export ({format}): {target.name}");
            AppendTransformRecursive(target.transform, 0, sb);

            File.WriteAllText(filePath, sb.ToString());
            return filePath;
        }

        private static void AppendTransformRecursive(Transform current, int depth, StringBuilder sb)
        {
            string indent = new string(' ', depth * 2);
            Component[] components = current.GetComponents<Component>();
            string componentNames = string.Join(", ", System.Array.ConvertAll(components, c => c != null ? c.GetType().Name : "MissingScript"));
            sb.AppendLine($"{indent}- {current.name} [{componentNames}]");

            for (int i = 0; i < current.childCount; i++)
            {
                AppendTransformRecursive(current.GetChild(i), depth + 1, sb);
            }
        }
    }
}

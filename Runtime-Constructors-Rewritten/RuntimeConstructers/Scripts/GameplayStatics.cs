using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RuntimeConstructers
{
    public static class GameplayStatics
    {
        /// <summary>
        /// Checks whether a GameObject is an asset/prefab in memory rather than an instance in an active scene.
        /// </summary>
        public static bool IsPrefab(this GameObject gameObject)
        {
            if (gameObject == null) return false;

            // If the GameObject's scene has no name and buildIndex is -1, it is not part of an active scene hierarchy.
            return string.IsNullOrEmpty(gameObject.scene.name) && gameObject.scene.buildIndex == -1;
        }

        public static List<Component> FindAllPrefabsWithComponent(Type type)
        {
            if (type == null || !type.IsSubclassOf(typeof(Component)))
            {
                throw new ArgumentException("Type must be a non-null subclass of Component.", nameof(type));
            }

            UnityEngine.Object[] foundObjects = Resources.FindObjectsOfTypeAll(type);
            var list = new List<Component>(foundObjects.Length);

            for (int i = 0; i < foundObjects.Length; i++)
            {
                if (foundObjects[i] is Component comp && comp.gameObject.IsPrefab())
                {
                    list.Add(comp);
                }
            }

            return list;
        }

        public static List<T> FindAllPrefabsWithComponent<T>() where T : Component
        {
            T[] foundComponents = Resources.FindObjectsOfTypeAll<T>();
            var list = new List<T>(foundComponents.Length);

            for (int i = 0; i < foundComponents.Length; i++)
            {
                if (foundComponents[i].gameObject.IsPrefab())
                {
                    list.Add(foundComponents[i]);
                }
            }

            return list;
        }

        public static List<GameObject> FindAllPrefabs()
        {
            GameObject[] foundObjects = Resources.FindObjectsOfTypeAll<GameObject>();
            var list = new List<GameObject>(foundObjects.Length);

            for (int i = 0; i < foundObjects.Length; i++)
            {
                if (foundObjects[i].IsPrefab())
                {
                    list.Add(foundObjects[i]);
                }
            }

            return list;
        }

        public static GameObject FindChildGameObjectByName(this GameObject gameObject, string name, bool recursive = false)
        {
            if (gameObject == null) return null;

            Transform parent = gameObject.transform;
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform child = parent.GetChild(i);
                if (child.name == name)
                {
                    return child.gameObject;
                }

                if (recursive)
                {
                    GameObject found = child.gameObject.FindChildGameObjectByName(name, true);
                    if (found != null) return found;
                }
            }

            return null;
        }

        public static Scene CreateScene(string sceneName, bool isBlankScene)
        {
            Scene previousScene = SceneManager.GetActiveScene();
            Scene newScene = SceneManager.CreateScene(sceneName);
            SceneManager.SetActiveScene(newScene);

            if (previousScene.IsValid() && previousScene.isLoaded && previousScene != newScene)
            {
                SceneManager.UnloadSceneAsync(previousScene);
            }

            if (!isBlankScene)
            {
                var cameraGo = new GameObject("Main Camera", typeof(Camera), typeof(AudioListener))
                {
                    tag = "MainCamera"
                };
                cameraGo.transform.position = new Vector3(0f, 1f, -10f);

                var lightGo = new GameObject("Directional Light", typeof(Light));
                var light = lightGo.GetComponent<Light>();
                light.type = LightType.Directional;
                lightGo.transform.localEulerAngles = new Vector3(50f, -30f, 0f);
                RenderSettings.sun = light;
            }

            return newScene;
        }

        public static Scene CreateScene(string sceneName, bool isBlankScene, params GameObject[] gameObjectsToAdd)
        {
            Scene scene = CreateScene(sceneName, isBlankScene);
            if (gameObjectsToAdd != null)
            {
                for (int i = 0; i < gameObjectsToAdd.Length; i++)
                {
                    if (gameObjectsToAdd[i] != null)
                    {
                        UnityEngine.Object.Instantiate(gameObjectsToAdd[i]);
                    }
                }
            }
            return scene;
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

namespace RuntimeGUI
{
public static class GameplayStatics
{
        public static bool IsPrefab(this GameObject gameObject)
        {
            if (gameObject == null) return false;

            // 1. Wenn die Szene des GameObjects keinen Namen und keinen validen Pfad hat, 
            //    ist es kein Teil der aktiven Hierarchie (typisch für geladene Assets/Prefabs).
            return string.IsNullOrEmpty(gameObject.scene.name) && gameObject.scene.buildIndex == -1;
        }

         public static List<Component> FindAllPrefabsWithComponent(Type type)
    {
        if (type == null || !type.IsSubclassOf(typeof(Component)))
        {
            throw new Exception("type must be type of Component and not Component or null");
        }
        var foundPrefabs = Resources.FindObjectsOfTypeAll(type) as Component[];
        var list = new List<Component>();
        for (int i = 0; i < foundPrefabs.Length; i++)
        {
            if (foundPrefabs[i].gameObject.IsPrefab())
            {
                list.Add(foundPrefabs[i]);
            }
        }
        return list;
    }

    public static List<T> FindAllPrefabsWithComponent<T>() where T : Component
    {
        var foundPrefabs = Resources.FindObjectsOfTypeAll<T>();
        var list = new List<T>();
        for (int i = 0; i < foundPrefabs.Length; i++)
        {
            if (foundPrefabs[i].gameObject.IsPrefab())
            {
                list.Add(foundPrefabs[i]);
            }
        }
        return list;
    }

    public static List<GameObject> FindAllPrefabs()
    {
        var foundPrefabs = Resources.FindObjectsOfTypeAll<GameObject>();
        var list = new List<GameObject>();
        for (int i = 0; i < foundPrefabs.Length; i++)
        {
            if (foundPrefabs[i].gameObject.IsPrefab())
            {
                list.Add(foundPrefabs[i]);
            }
        }
        return list;
    }

    public static GameObject FindChildGameObjectByName(this GameObject gameObject, string name)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            var child = gameObject.transform.GetChild(i);
            if (child.name == name)
            {
                return child.gameObject;
            }
        }
        return null;
    }

    public static void CreateScene(string SceneName, bool IsBlankScene)
    {
        SceneManager.CreateScene(SceneName);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName));
        if (!IsBlankScene)
        {
            new GameObject("Main Camera", typeof(Camera), typeof(AudioListener));
            GameObject gameObject = new GameObject("Directional Light", typeof(Light));
            RenderSettings.sun = gameObject.GetComponent<Light>();
            gameObject.GetComponent<Light>().type = LightType.Directional;
            gameObject.GetComponent<Transform>().localEulerAngles = new Vector3(50f, -30f, 0f);
        }
    }

    public static void CreateScene(string SceneName, bool IsBlankScene, params GameObject[] GameObjectsToAdd)
    {
        CreateScene(SceneName, IsBlankScene);
        for (int i = 0; i < GameObjectsToAdd.Length; i++)
        {
            UnityEngine.Object.Instantiate(GameObjectsToAdd[i]);
        }
    }
}
}

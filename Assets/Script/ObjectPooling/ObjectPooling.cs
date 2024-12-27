using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling Instance {  get; private set; }
    private Dictionary<string, Queue<GameObject>> poolDictionary = new Dictionary<string, Queue<GameObject>>();
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);
    }
    public void CreatePool(string key, GameObject prefabs, int quantity)
    {
        if (!this.poolDictionary.ContainsKey(key))
        {
            Queue<GameObject> poolQueue = new Queue<GameObject>();
            for(int i =0; i < quantity; i++)
            {
                GameObject obj = Instantiate(prefabs);
                obj.SetActive(false);
                poolQueue.Enqueue(obj);
            }
            this.poolDictionary.Add(key, poolQueue);
        }
    }
    public GameObject GetPool(string key, GameObject prefab)
    {
        if(this.poolDictionary.ContainsKey(key))
        {
            if (this.poolDictionary[key].Count > 0)
            {
                GameObject obj = poolDictionary[key].Dequeue();
                obj.SetActive(true);
                return obj;
            }
            else
            {
                GameObject obj = Instantiate(prefab);
                return obj;
            }
        }
        return null;
    }
    public void ReturnToPool(string key, GameObject prefab)
    {
        if (!this.poolDictionary.ContainsKey(key))
        {
            poolDictionary[key] = new Queue<GameObject>();
            prefab.SetActive(false);
            poolDictionary[key].Enqueue(prefab);
        }
        else
        {
            prefab.SetActive(false);
            poolDictionary[key].Enqueue(prefab);
        }
    }
}

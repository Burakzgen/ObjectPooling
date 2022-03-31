using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;
    // What object to instantiate 
    public GameObject objectToPool;
    // List of objects that can be used
    public List<GameObject> pooledObjects;
    // List count
    public int amountToPool;

    public bool willGrow = true;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            pooledObjects.Add(tmp);
            tmp.SetActive(false);
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        // Listenin deðerini büyütmek için kullanýlan kod bloðudur. ( Verilen deðerin yetersizliði durumda çalýþýr )
        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Vector3 SpawnPosition =(Input.mousePosition);

        GameObject olusturulacak_objeAdý = ObjectPool.Instance.GetPooledObject();
        if (olusturulacak_objeAdý != null)
        {
            olusturulacak_objeAdý.SetActive(true);
            olusturulacak_objeAdý.transform.localPosition = SpawnPosition;
        }
    }
}

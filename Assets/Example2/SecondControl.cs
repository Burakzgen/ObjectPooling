using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondControl : MonoBehaviour
{
    public CubePrefab cubePrefab;
    public Transform cubeFolder;
    List<CubePrefab> cubePool;
    public int poolAmountAtStart;


    private void Awake()
    {
        cubePool = new List<CubePrefab>();

        for (int i = 0; i < poolAmountAtStart; i++)
        {
            CubePrefab newCube = Instantiate(cubePrefab);
            newCube.transform.parent = cubeFolder;
            newCube.gameObject.SetActive(false);
            cubePool.Add(newCube);
        }
    }

    CubePrefab GetCubeFromPool()
    {
        for (int i = 0; i < cubePool.Count; i++)
        {
            if (!cubePool[i].gameObject.activeSelf)
            {
                return cubePool[i];
            }
        }
        return null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateCubePrefab();
        }
    }

    private void CreateCubePrefab()
    {
        Vector3 mousePos = Input.mousePosition;

        CubePrefab newCube = GetCubeFromPool();


        if (newCube == null)
        {
            //Verilen adet sayýsý kadar üretimi yapar fazlasýný istersek listeye ekleme yapabildik.
            newCube = Instantiate(cubePrefab);
            newCube.transform.parent = cubeFolder;
            cubePool.Add(newCube);


            //return;//Verilen adet sayýsý kadar üretimi yapar fazlasýnda hata vermesin diye null döndürdük.
        }


        newCube.gameObject.SetActive(true);
        newCube.Init(mousePos);
    }
}

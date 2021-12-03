using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePrefab : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.SetActive(false);
        }
    }

    //De�i�kenlerin yaz�labilece�i yer. Cube karakterin t�m de�i�kenleri buraya yaz�labilir.(Sa�l�k vb)
    public void Init(Vector3 position)
    {
        transform.position = position;
    }
}

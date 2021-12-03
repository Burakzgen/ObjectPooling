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

    //Deðiþkenlerin yazýlabileceði yer. Cube karakterin tüm deðiþkenleri buraya yazýlabilir.(Saðlýk vb)
    public void Init(Vector3 position)
    {
        transform.position = position;
    }
}

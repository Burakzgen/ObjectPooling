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

    //Değişkenlerin yazılabileceği yer. Cube karakterin tüm değişkenleri buraya yazılabilir.(Sağlık vb)
    public void Init(Vector3 position)
    {
        transform.position = position;
    }
}

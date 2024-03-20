using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTower : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DragAndDrop>())
        {
            Destroy(other.gameObject);
        }
    }
}

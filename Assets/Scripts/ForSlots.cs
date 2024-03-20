using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSlots : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DragAndDrop>())
        {
            other.transform.SetParent(gameObject.transform);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<DragAndDrop>())
        {
            other.transform.position = gameObject.transform.position;
        }
    }
}


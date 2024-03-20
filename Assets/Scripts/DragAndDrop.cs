using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 initialPosition;
    private bool isDragging = false;
    public bool slotIsFree;

    private void Start()
    {
        slotIsFree = true;
    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
        initialPosition = transform.position;
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }

    private void OnMouseUp()
    {
        if (!isDragging) return;

        isDragging = false;
        Collider[] colliders = Physics.OverlapSphere(transform.position, 0.1f);

        bool isColliding = false;

        foreach (var collider in colliders)
        {
            if (collider.gameObject != gameObject)
            {
                isColliding = true;
                break;
            }
        }

        if (!isColliding) //|| !slotIsFree
        {
            transform.position = initialPosition;  //возвращаем объекту исходную позицию, если он не сталкивается ни с чем
            slotIsFree = true;
        }
    }
}
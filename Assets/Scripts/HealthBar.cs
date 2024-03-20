using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private RectTransform healthBarTransform;
    private Transform target;

    private void Awake()
    {
        healthBarTransform = GetComponent<RectTransform>();
    }

    public void Initialize(Transform targetTransform)
    {
        target = targetTransform;
    }

    private void Update()
    {
        if (target != null)
        {
            healthBarTransform.position = target.position + Vector3.up * 3;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateHealthBar(float normalizedHealth)
    {
        healthBarTransform.localScale = new Vector3(normalizedHealth, 1, 1);
    }
}
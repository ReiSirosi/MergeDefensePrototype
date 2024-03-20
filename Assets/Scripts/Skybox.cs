using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : MonoBehaviour
{
    public float rotationSpeed = 1f;
    private Material skyboxMaterial;

    void Start()
    {
        skyboxMaterial = RenderSettings.skybox;
    }

    void Update()
    {
        // Получаем текущий поворот скайбокса
        float currentRotation = skyboxMaterial.GetFloat("_Rotation");

        // Увеличиваем угол поворота
        currentRotation += rotationSpeed * Time.deltaTime;

        // Применяем новый угол поворота к скайбоксу
        skyboxMaterial.SetFloat("_Rotation", currentRotation);
    }
}

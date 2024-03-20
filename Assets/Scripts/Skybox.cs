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
        // �������� ������� ������� ���������
        float currentRotation = skyboxMaterial.GetFloat("_Rotation");

        // ����������� ���� ��������
        currentRotation += rotationSpeed * Time.deltaTime;

        // ��������� ����� ���� �������� � ���������
        skyboxMaterial.SetFloat("_Rotation", currentRotation);
    }
}

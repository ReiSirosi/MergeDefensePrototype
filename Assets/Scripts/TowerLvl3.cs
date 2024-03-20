using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLvl3 : MonoBehaviour
{
    private GameConroller gameConroller;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;

    [SerializeField] private float fireRate = 1f;
    [SerializeField] private float range = 3f;

    [SerializeField] private GameObject nextLevelTower;

    private float fireCountdown = 0f;
    private bool spawnNewTower;
    private Vector3 positionTower;
    public bool shootIsEnabled;

    private void Start()
    {
        spawnNewTower = true;
        shootIsEnabled = false;
    }

    private void Update()
    {
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    private void Shoot()
    {
        if (shootIsEnabled)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
            GameObject nearestEnemy = null;
            float shortestDistance = Mathf.Infinity;

            foreach (GameObject enemy in enemies)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
                if (distanceToEnemy < shortestDistance)
                {
                    shortestDistance = distanceToEnemy;
                    nearestEnemy = enemy;
                }
            }

            if (nearestEnemy != null && shortestDistance <= range)
            {
                GameObject bulletObject = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Bullet bullet = bulletObject.GetComponent<Bullet>();
                if (bullet != null)
                {
                    bullet.Seek(nearestEnemy.transform);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tower3")
        {
            if (spawnNewTower)
            {
                other.GetComponent<TowerLvl3>().spawnNewTower = false;
            }

            positionTower = other.transform.position;
            StartCoroutine(SpawnNextLevelTower());
        }

        if (other.gameObject.tag == "InventorySlots")
        {
            shootIsEnabled = false;
        }
        else if (other.gameObject.tag == "ShootingSlots")
        {
            shootIsEnabled = true;
        }
    }

    IEnumerator SpawnNextLevelTower()
    {
        if (spawnNewTower)
        {
            Instantiate(nextLevelTower, positionTower, Quaternion.identity);
        }
        Destroy(gameObject);
        yield return null;
    }
}

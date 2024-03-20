using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
        [SerializeField] private GameObject[] monsterPrefabs;
        public int currentLevel = 1;
        private float spawnDelay = 1f;

        private void Update()
        {
            LevelCheck();
        }

    private void LevelCheck()
    {
        if (GameConroller.lvl == currentLevel && GameConroller.enemiesCountOnMap == 0)
        {
            int index;
            int enemiescount;

            if (currentLevel <= 24)
            {
                index = 0;
                enemiescount = currentLevel;
            }
            else if (currentLevel == 25)
            {
                index = 9;
                enemiescount = 1;
            }
            else if (currentLevel >= 26 && currentLevel <= 49)
            {
                index = 1;
                enemiescount = currentLevel - 24;
            }
            else if (currentLevel == 50)
            {
                index = 10;
                enemiescount = 1;
            }
            else if (currentLevel >= 51 && currentLevel <= 74)
            {
                index = 2;
                enemiescount = currentLevel - 49;
            }
            else if (currentLevel == 75)
            {
                index = 11;
                enemiescount = 1;
            }
            else if (currentLevel >= 76 && currentLevel <= 99)
            {
                index = 3;
                enemiescount = currentLevel - 74;
            }
            else if (currentLevel == 100)
            {
                index = 12;
                enemiescount = 1;
            }
            else if (currentLevel >= 101 && currentLevel <= 124)
            {
                index = 4;
                enemiescount = currentLevel - 100;
            }
            else if (currentLevel == 125)
            {
                index = 13;
                enemiescount = 1;
            }
            else if (currentLevel >= 126 && currentLevel <= 149)
            {
                index = 5;
                enemiescount = currentLevel - 125;
            }
            else if (currentLevel == 150)
            {
                index = 14;
                enemiescount = 1;
            }
            else if (currentLevel >= 151 && currentLevel <= 174)
            {
                index = 6;
                enemiescount = currentLevel - 150;
            }
            else if (currentLevel == 175)
            {
                index = 15;
                enemiescount = 1;
            }
            else if (currentLevel >= 176 && currentLevel <= 199)
            {
                index = 7;
                enemiescount = currentLevel - 175;
            }
            else if (currentLevel == 200)
            {
                index = 16;
                enemiescount = 1;
            }
            else if (currentLevel >= 201 && currentLevel <= 225)
            {
                index = 7;
                enemiescount = currentLevel - 198;
            }
            else if (currentLevel >= 226 && currentLevel <= 249)
            {
                index = 8;
                enemiescount = currentLevel - 225;
            }
            else if (currentLevel == 250)
            {
                index = 17;
                enemiescount = 1;
            }
            else if (currentLevel >= 251 && currentLevel <= 275)
            {
                index = 18;
                enemiescount = currentLevel - 250;
            }
            else if (currentLevel >= 276 && currentLevel <= 299)
            {
                index = 19;
                enemiescount = currentLevel - 275;
            }
            else if (currentLevel == 300)
            {
                index = 24;
                enemiescount = 1;
            }
            else if (currentLevel >= 301 && currentLevel <= 324)
            {
                index = 20;
                enemiescount = currentLevel - 300;
            }
            else if (currentLevel == 325)
            {
                index = 25;
                enemiescount = 1;
            }
            else if (currentLevel >= 326 && currentLevel <= 349)
            {
                index = 21;
                enemiescount = currentLevel - 325;
            }
            else if (currentLevel == 350)
            {
                index = 26;
                enemiescount = 1;
            }
            else if (currentLevel >= 351 && currentLevel <= 374)
            {
                index = 22;
                enemiescount = currentLevel - 350;
            }
            else if (currentLevel == 375)
            {
                index = 27;
                enemiescount = 1;
            }
            else if (currentLevel >= 376 && currentLevel <= 399)
            {
                index = 23;
                enemiescount = currentLevel - 375;
            }
            else if (currentLevel == 400)
            {
                index = 28;
                enemiescount = 1;
            }
            else
            {
                return; // если уровень не входит в описанные выше услови€, прекращаем выполнение метода
            }

            StartCoroutine(CreateEnemies(enemiescount, monsterPrefabs[index]));
            IncreaseLevel();
        }
    }

        private void IncreaseLevel()
        {
            currentLevel++;
            GameConroller.lvl += 1;
        }
    private IEnumerator CreateEnemies(int enemiesCount, GameObject monsterPrefab)
    {
        for (int i = 0; i < enemiesCount; i++)
        {
            GameObject enemyClone = Instantiate(monsterPrefab, new Vector3(18.61f, 1.91f, 4.96f), monsterPrefab.transform.rotation);
            GameConroller.enemiesCountOnMap++;

            yield return new WaitForSeconds(spawnDelay); // «адержка перед спауном следующего врага
        }
    }
}

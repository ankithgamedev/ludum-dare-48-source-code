//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WaveSpawner : MonoBehaviour
//{
//    public enum SpawnState { SPAWNING, WAITING, COUNTING};

//    [System.Serializable]
//    public class Wave
//    {
//        public string name;
//        public Transform enemy;
//        public int count;
//        public float rate;
//    }

//    public Wave[] waves;
//    private int nextWave = 0;

//    public Transform[] spawnPoints;

//    public float timeBetweenWaves = 5f;
//    private float waveCountdown;

//    private float searchCountdown = 1f;

//    private SpawnState state = SpawnState.COUNTING;

//    private void Start()
//    {

//        if (spawnPoints.Length == 0)
//        {
//            Debug.LogError("No Spawn Points referenced.");
//        }
//        waveCountdown = timeBetweenWaves;
//    }

//    private void Update()
//    { 
//        if (state == SpawnState.WAITING)
//        {
//            if (!EnemyIsAlive())
//            {
//                WaveCompleted();
//            }
//            else
//            {
//                return;
//            }
//        }

//        if (waveCountdown <= 0)
//        {
//            if (state != SpawnState.SPAWNING)
//            {
//                StartCoroutine(SpawnWave(waves[nextWave]));
//            }
//        }
//        else
//        {
//            waveCountdown -= Time.deltaTime;
//        }
//    }

//    void WaveCompleted()
//    {
//        Debug.Log("Wave Completed!");

//        state = SpawnState.COUNTING;
//        waveCountdown = timeBetweenWaves;

//        if (nextWave + 1 > waves.Length - 1)
//        {
//            nextWave = 0;
//            Debug.Log("All waves completed! Looping...");
//        }
//        else
//        {
//            nextWave++;
//        }

//        nextWave++;
//    }

//    bool EnemyIsAlive()
//    {
//        searchCountdown -= Time.deltaTime;
//        if (searchCountdown <= 0f)
//        {
//            searchCountdown = 1f;
//            if (GameObject.FindGameObjectsWithTag("Enemy") == null)
//            {
//                return false;
//            }
//        }

//        return true;
//    }

//    IEnumerator SpawnWave(Wave _wave)
//    {
//        Debug.Log("Spawning Wave: " + _wave.name);

//        state = SpawnState.SPAWNING;

//        for (int i =0; i < _wave.count; i++)
//        {
//            SpawnEnemy(_wave.enemy);
//        }

//        state = SpawnState.WAITING;

//        yield break;
//    }

//    void SpawnEnemy(Transform _enemy)
//    {
//        Debug.Log("Spawning Enemy: " + _enemy.name);
//        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
//        Instantiate(_enemy, transform.position, transform.rotation);

//    }
//}

//************** REAL GAMES STUDIO ***************
//************************************************
//realgamesss.weebly.com
//gamejolt.com/@Real_Game
//realgamesss.newgrounds.com/
//real-games.itch.io/
//youtube.com/channel/UC_Adg-mo-IPg6uLacuQCZCQ
//************************************************

using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public TextMeshProUGUI waveCountText;
    int waveCount = 1;

    public float spawnRate = 1.0f;
    public float timeBetweenWaves = 3.0f;

    public int enemyCount;

    public GameObject enemy;
    public Transform spawnrpos;

    bool waveIsDone = true;

    void Update()
    {
        waveCountText.text = "Wave: " + waveCount.ToString();

        if (waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
    }

    IEnumerator waveSpawner()
    {
        waveIsDone = false;

        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemyClone = Instantiate(enemy, spawnrpos.position, spawnrpos.rotation);

            yield return new WaitForSeconds(spawnRate);
        }

        spawnRate -= 0.1f;
        enemyCount += 3;
        waveCount += 1;

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }
}   

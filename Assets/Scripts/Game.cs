using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    const int spawn = 10;
    const float ySpawn = -4.768372e-07f;
    const float xLow = 3.6f, xHigh = 96.8f;
    const float zLow = 8.3f, zHigh = 97.16f;
    public static int score = 0;
    public TMPro.TextMeshProUGUI scoreText;
    public List<GameObject> enemies;
    private void Start()
    {
        spawnEnemies();
    }
    private void Update()
    {
        scoreText.text = Game.score.ToString();
    }
    public static void incrementScore()
    {
        Game.score++;
    }

    void spawnEnemies()
    {
        for (int i = 0; i < spawn; i++)
        {
            Vector3 vt3;
            float x = Random.Range(xLow, xHigh);
            float z = Random.Range(zLow, zHigh);
            vt3 = new Vector3(x, ySpawn, z);
            Debug.Log(vt3);
            int c = Random.Range(0, enemies.Count);
            GameObject enemy = Instantiate(enemies[c], vt3, Quaternion.identity);
        }
    }
}

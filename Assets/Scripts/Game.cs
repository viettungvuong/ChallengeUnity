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
        GameObject[] temp = GameObject.FindGameObjectsWithTag("enemy");
        enemies = new List<GameObject>(temp);
        for (int i = 0; i < spawn; i++)
        {

        }
    }
}

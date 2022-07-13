using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    const int spawn = 10;
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

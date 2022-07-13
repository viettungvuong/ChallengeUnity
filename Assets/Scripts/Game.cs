using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int score = 0;
    public static void incrementScore()
    {
        Game.score++;
    }
}

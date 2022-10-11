using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Level High Score: " + GetScore();
    }
    public static int GetScore()
       {

        if (MissionDemolition.level == 0)
        {
            return PlayerPrefs.GetInt("HighScore0");

        }
        else if (MissionDemolition.level == 1)
        {
            return PlayerPrefs.GetInt("HighScore1");

        }
        else if (MissionDemolition.level == 2)
        {
            return PlayerPrefs.GetInt("HighScore2");

        }
        else return 0;
    }

    public static void SetScore(int score)
    {
        if (MissionDemolition.level == 0)
        {
            PlayerPrefs.SetInt("HighScore0", score);

        }
        else if (MissionDemolition.level == 1)
        {
            PlayerPrefs.SetInt("HighScore1", score);

        }
        else if (MissionDemolition.level == 2)
        {
             PlayerPrefs.SetInt("HighScore2", score);

        }
    }
}

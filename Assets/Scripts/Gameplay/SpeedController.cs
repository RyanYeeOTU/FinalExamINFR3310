using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpeedController : MonoBehaviour
{
    public static SpeedController instance;
    public TextMeshProUGUI text;

    public int EnemiesKilled = 0;

    // Update is called once per frame
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public virtual void changeSpeed(bool increaseSpeed)
    {
        if (increaseSpeed == true)
        {
            PlayerManager.instance.player.GetComponent<PlayerController>().speedChange();
            EnemiesKilled += 1;
            Debug.Log(EnemiesKilled);
            increaseSpeed = false;
        }
    }
    public void ChangeScore(int EnemyCounter)
    {
        EnemiesKilled += EnemyCounter;
        Debug.Log(EnemiesKilled);
        text.text = "Enemies Killed: " + EnemiesKilled.ToString();
    }
}

using JetBrains.Annotations;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    public static bool onRun = false;
    public static bool offRun = false;
    public static bool onEnemy = false;
    public static bool offEnemy = false;
    public static bool onBuzz = false;
    public static bool offBuzz = false;
    public static bool onEnd = false;
    public static bool offEnd = false;
    public static bool onDie = false;
    public static bool offDie = false;

    public AudioSource Enemy1;
    public AudioSource Enemy2;
    public AudioSource Enemy3;

    public AudioSource Run;
    public AudioSource Buzz;

    public AudioSource Begin;
    public AudioSource End;

    public AudioSource Die;

    void Start()
    {
        onRun = true;
        onEnemy = true;
        onBuzz = true;
        Begin.Play();
    }
    public void Update()
    {
        if (onRun == true)
        {
            runStart();
            onRun = false;
        }
        if (offRun == true)
        {
            Invoke(nameof(runStop), 1f);
            offRun = false;
        }
        if (onEnemy == true)
        {
            enemyStart();
            onEnemy = false;
        }
        if (offEnemy == true)
        {
            Invoke(nameof(enemyStop), 1f);
            offEnemy = false;
        }
        if (onBuzz == true)
        {
            buzzOn();
            onBuzz = false;
        }
        if (offBuzz == true)
        {
            Invoke(nameof(buzzOff), 1f);
            offBuzz = false;
        }
        if (onEnd == true)
        {
            endOn();
            onEnd = false;
            Debug.Log("Sound playing!");
        }
        if (offEnd == true)
        {
            endOff();
            onEnd = false;
        }
        if (onDie == true)
        {
            Die.Play();
            onDie = false;
        }
        if (offDie == true)
        {
            Die.Stop();
            offDie = false;
        }
    }
    public void runStart()
    {
        Run.Play();
    }
    public void runStop()
    {
        Run.Stop();
    }
    public void enemyStart()
    {
        Enemy1.Play();
        Enemy2.Play();
        Enemy3.Play();
    }
    public void enemyStop()
    {
        Enemy1.Stop();
        Enemy2.Stop();
        Enemy3.Stop();
    }
    public void buzzOff()
    {
        Buzz.Stop();
    }
    public void buzzOn()
    {
        Buzz.Play();
    }
    public void endOn()
    {
        End.Play();
    }
    public void endOff()
    {
        End.Stop();
    }
}

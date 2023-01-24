using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{

    // Use this for initialization
    public int level = 8;
    public GameObject p;
    EnemyColider en;
    GameObject[] pauseObjects;

    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        en = p.GetComponent<EnemyColider>();

        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        //hidePaused();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                //showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                //hidePaused();
            }
        }
    }
    public int getLevel()
    {
        return level;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Portal"))
        {
            //level++;
            SceneManager.LoadScene(level);
            en.incLevel();


        }
    }
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
}

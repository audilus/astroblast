using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] HelmetSprites;
    public Image HelmetUI;
    public GameObject Player;
    public EnemyColider MainHealth;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        MainHealth = Player.GetComponent<EnemyColider>();
    }

    void Update()
    {
        HelmetUI.sprite = HelmetSprites[MainHealth.health];
    }
}
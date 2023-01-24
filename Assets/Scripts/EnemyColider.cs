using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnemyColider : MonoBehaviour {

	// Use this for initialization
	public int health = 3;
	public Text healthText;
	LevelManager manager;
	public int Level = 8;
	void Start () {
		health = 3;
		setText();
	}
	
	// Update is called once per frame
	void Update () {
		if(health < 1)
		{
			//manager = this.gameObject.GetComponent<LevelManager>();
			//Level = manager.getLevel();
			SceneManager.LoadScene(8);
		}
		
		
	}
	void setText()
	{
		healthText.text = "Health: " + health.ToString();
	}
	public void incLevel()
	{
		//Level++;
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		//Debug.Log("e");
		if(col.gameObject.tag.Equals("Enemy"))
		{
			health--;
			setText();
			Debug.Log(health);
		}
		if(col.gameObject.tag.Equals("DeathTile"))
		{
			//SceneManager.LoadScene(8);
			health = 0;
		}

		
	}
	
}

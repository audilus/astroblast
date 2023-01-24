using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

	// Use this for initialization
	public List<GameObject> enemies = new List<GameObject>();
	public GameObject blocker;
	public int nullcounter = 0;
	public int numTargets;
	void Start () {
		foreach(GameObject g in enemies)
		{
			g.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(enemies.Count < 1 || nullcounter > numTargets)
		{
			Debug.Log("all my enemies are dead");
			blocker.SetActive(false);
			
		}

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("player entered trigger");
		if(col.gameObject.tag.Equals("Player"))
		{
			Debug.Log("player is here");
			foreach(GameObject g in enemies)
			{
				
				if(g != null)
					g.SetActive(true);

				if(g == null)
				nullcounter++;

			}	
		}

	}
}

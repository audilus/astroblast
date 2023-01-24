using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	// Use this for initialization
	public List<GameObject> items = new List<GameObject>();
	public GameObject coinObj;
	public bool canHoldItems = false;
	public int numCoins;
	Random r;

	void Start () {
		r = new Random();
		int x = Random.Range(1, 10);
		if(x < 4)
			canHoldItems = true;
		numCoins = Random.Range(1, 10);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void spill()
	{
		for(int i = 0; i < numCoins; i++)
		{
			Instantiate(coinObj);
		}
		foreach(GameObject g in items)
		{
			r = new Random();
			GameObject i = Instantiate(g);
			i.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(1, 8), Random.Range(1, 8));
		}
	}
}

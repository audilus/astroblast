using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour {
	
	// Use this for initialization
	public int numCoins;
	
	public GameObject p;
	public Text coinText;
	void Start () {
		textToString();
	}
	void textToString()
	{
		coinText.text =  numCoins.ToString();
	}
	public void incCoins(int x)
	{
		numCoins+=x;
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag.Equals ("Coin"))
		{
			
			numCoins++;
			//Debug.Log(numCoins);
			//Debug.Log("you've donw it you cool cat");
			Destroy(col.gameObject);
			textToString();
		}
		if(col.gameObject.name == "Coin")
		{
		
			
		}
		if(col.gameObject != null)
		{
			//Debug.Log("not null");
		}
		//Destroy(col.gameObject);

			//Debug.Log(numCoins);
	}

	
	// Update is called once per frame
	void Update () {
		///Debug.Log("im on");
		//Debug.Log(numCoins);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour {

	public bool cool = true;
	public void ring(string s)
	{
		Debug.Log(s);
	}
	public void ChangeScene(int nextScene)
	{
		SceneManager.LoadScene(nextScene);
	}
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
	//}
	public void Test(int a)
	{
		Debug.Log("ayeeeeee");
	}
}

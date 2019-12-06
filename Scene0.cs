using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour {
	
	 public float targetTime = 10.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		targetTime -= Time.deltaTime;
 
 		if (targetTime <= 0.0f)
 		{
			 SceneManager.LoadScene (1);
	 	}
	}

}

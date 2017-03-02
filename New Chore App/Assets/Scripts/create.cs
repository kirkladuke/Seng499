using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class create : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnCreate(int pageNumbers)
	{

		SceneManager.LoadScene (pageNumbers);


	}
}

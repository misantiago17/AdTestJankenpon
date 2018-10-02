using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickbutton : MonoBehaviour {

    public Ad adthing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RequestBanner()
    {
        adthing.RequestBanner();
    }

    public void DestroyBanner()
    {
        adthing.DestroyBanner();
    }
}

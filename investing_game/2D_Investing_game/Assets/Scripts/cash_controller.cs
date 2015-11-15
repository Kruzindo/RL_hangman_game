using UnityEngine;
using System.Collections;

public class cash_controller : MonoBehaviour {

    private cash_view _view;
    private cash_model _model;

    // Use this for initialization
    void Start () {
        _view
        = new cash_view();
        _model
        = new cash_model();
    }
	
	// Update is called once per frame
	void Update () {

    }


    public cash_controller()
    {
        Debug.Log("Hi");
        
    }
}

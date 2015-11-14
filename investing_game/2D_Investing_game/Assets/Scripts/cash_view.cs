using UnityEngine;
using System.Collections;

public class cash_view : MonoBehaviour {

    private cash_controller _controller;
    private cash_model _model;

    public void Start()
    {
        _controller
            = new cash_controller();
        _model
            = new cash_model();
    }

}

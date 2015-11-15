using UnityEngine;
using System.Collections;

public class cash_view : MonoBehaviour {

    private cash_controller _controller;
    private cash_model _model;

    public void OnGui()
    {

        Rect buttonPosition = new Rect(500, 400, 200, 100);
        if (GUI.Button(buttonPosition, "Test"))
        {
            Debug.Log("gello zobbewt :D");
        }
    }

    public cash_view()
    {
        _controller
        = new cash_controller();
        _model
        = new cash_model();
    }
}

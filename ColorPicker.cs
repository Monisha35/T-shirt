using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour {

    public Material[] PlayerColorMat;
    Material CurrMat;
    new Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    //render blue color
    public void BlueColor()
    {
        renderer.material = PlayerColorMat[0];
        CurrMat = renderer.material;
    }

    //render red color
    public void RedColor()
    {
        renderer.material = PlayerColorMat[1];
        CurrMat = renderer.material;
    }

    //render greencolor
    public void whiteColor()
    {
        renderer.material = PlayerColorMat[2];
        CurrMat = renderer.material;
    }

    //render yellow color

    public void grayColor()
    {
        renderer.material = PlayerColorMat[3];
        CurrMat = renderer.material;
    }
    public void black()
    {
        renderer.material = PlayerColorMat[4];
        CurrMat = renderer.material;
    }
    public void pink()
    {
        renderer.material = PlayerColorMat[5];
        CurrMat = renderer.material;
    }
    public void yellow()
    {
        renderer.material = PlayerColorMat[6];
        CurrMat = renderer.material;
    }
    public void green()
    {
        renderer.material = PlayerColorMat[7];
        CurrMat = renderer.material;
    }
}

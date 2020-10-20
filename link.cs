using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link : MonoBehaviour {

    public void jogger()
    {
        Application.LoadLevel("s1");
    }

    public void roundneck()
    {
        Application.LoadLevel("s2");
    }

    public void girlstshirt()
    {
        Application.LoadLevel("s4");
    }

    public void boystshirt()
    {
        Application.LoadLevel("s3");
    }

   /* public void red()
    {
        Application.LoadLevel("s5");
    }*/

    public void back()
    {
        Application.LoadLevel("main1");
    }
    public void model3d()
    {
        Application.LoadLevel("3d-model");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void call()
    {
        Application.OpenURL("tel://8888888888");
    }
}

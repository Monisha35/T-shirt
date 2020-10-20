using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour {

    public void jogger()
    {
        Toast.Instance.Show("Jogging Clothing \nCloth Type: Polyester");
    }
    public void rigger()
    {
        Toast.Instance.Show("Ringer T – shirt  \nCloth Type: Rayon ");
    }
    public void boys()
    {
        Toast.Instance.Show("Polo collar  \nCloth Type: Linen");
    }
    public void girls()
    {
        Toast.Instance.Show("Basic half sleeve T-shirt \nCloth Type: Cotton ");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{

    public Material matRed;
    public Material matGreen;
    public Material matBlue;

    

    // Bu buton için olan kod bunu silme
    public void RedColor()
    {
        GetComponent<Renderer>().material = matRed;
    }

    public void GreenColor()
    {
        GetComponent<Renderer>().material = matGreen;
    }

    public void BlueColor()
    {
        GetComponent<Renderer>().material = matBlue;
    }
}

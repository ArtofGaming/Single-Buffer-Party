using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guest : MonoBehaviour
{
    public Guest()
    {
        talking = false;
    }
    public bool talking;
    public void update() { }

    public void Reset()
    {
        talking = false;
    }
    public void Talk()
    {
        talking = true;
        Debug.Log( "Someone is talking");
    }


}

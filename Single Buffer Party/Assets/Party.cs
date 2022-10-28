using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    public List<Guest> guests = new List<Guest>();
    public void update()
    {
        for(int i = 0; i < 3; i++)
        {
            guests[i].update();
            guests[i].Reset();
        }
    }
}

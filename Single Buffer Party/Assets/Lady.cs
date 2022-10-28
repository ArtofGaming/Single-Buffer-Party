using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lady : Guest
{
    private Guest facing;
    public void Face(Guest guest)
    {
        facing = guest;
    }

    void update()
    {
        if (talking)
        {
            facing.Talk();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Party table;
    //Guest sue = new Guest();

    public void OnButtonClick()
    {
        Lady liz = new Lady();
        Lady beth = new Lady();
        Lady sue = new Lady();
        table.guests.Add(sue);
        table.guests.Add(beth);
        table.guests.Add(liz);

        liz.Face(beth);
        beth.Face(sue);
        sue.Face(liz);

        liz.Talk();
        table.update();
    }

    // Start is called before the first frame update
    void Start()
    {
        table = GetComponent<Party>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

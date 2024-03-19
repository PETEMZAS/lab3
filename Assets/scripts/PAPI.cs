using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAPI : MonoBehaviour
{
    [SerializeField] private GameObject steve;
    public static int stevecount = 0;

    

    void GIVESTIEVE()
    {
        var temp = Instantiate(steve);
        stevecount++;
        temp.transform.position = this.transform.position;
    }
    private void Update()
    {
        if (stevecount < 1)
        {
            GIVESTIEVE();
        }
    }
}

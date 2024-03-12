using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewkaboom : MonoBehaviour
{
private float tiktak=0;

    void Update()
    {
        tiktak += Time.deltaTime;
		if (tiktak > 5)
		{
            Destroy(this.gameObject);
		}
    }
}

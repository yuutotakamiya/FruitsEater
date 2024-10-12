using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsMoveManager : MonoBehaviour
{
    private void Start()
    {
        
    }

    void Update()
    {

        //À•W‚ğ‘‚«Š·‚¦‚é
        transform.position -= new Vector3(0, 0, 10f) * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsMoveManager : MonoBehaviour
{

    void Update()
    {

        //座標を書き換える
        transform.position -= new Vector3(0, 0, 10f) * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsMoveManager : MonoBehaviour
{

    void Update()
    {

        //���W������������
        transform.position -= new Vector3(0, 0, 10f) * Time.deltaTime;
    }
}

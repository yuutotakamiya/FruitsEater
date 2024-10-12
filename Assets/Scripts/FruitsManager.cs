using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsManager : MonoBehaviour
{
    public static FruitsManager instance;

    public enum fruits
    {
        apple,
        banana,
        persimmon, //Š`
        peach,
        pear, //—œ
        max
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

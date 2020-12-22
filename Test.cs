using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        SpecialCollection newCol = new SpecialCollection(new string[] { "один", "два", "три", "четыре", "пять" });
        foreach (string s in newCol)
        {
            Debug.Log(s);
        }
    }
}

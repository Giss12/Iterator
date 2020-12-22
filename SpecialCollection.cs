using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCollection : IEnumerable
{
    private string[] arraystring;
    public string[] GetItems
    {
        get
        {
            return arraystring;
        }
    }
    public SpecialCollection(string[] arr)
    {
        arraystring = arr;
    }

    public IEnumerator GetEnumerator()
    {
        return new SuperCollection(this);
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SuperCollection : IEnumerator
{
    private SpecialCollection collection;
    private int Pos = -1;
    public SuperCollection(SpecialCollection sc)
    {
        collection = sc;
    }

    public object Current
    {
        get
        {
            return collection.GetItems.OrderBy(c => c.Length).ToArray()[Pos];
        }
    }

    public bool MoveNext()
    {
        if(Pos < collection.GetItems.Length)
        {
            Pos++;
        }
        return Pos < collection.GetItems.Length;
    }

    public void Reset()
    {
        Pos = -1;
    }
}

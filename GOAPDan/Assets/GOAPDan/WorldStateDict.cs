using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStateDict  {

    public Dictionary<int, Vector3> states = null;

    public WorldStateDict()
    {
        states = new Dictionary<int, Vector3>();
    }

    public WorldStateDict(WorldStateDict c)//makes a deep copy of the dictionary
    {
        int count = c.states.Values.Count;
        int[] labels = new int[count];
        Vector3[] values = new Vector3[count];
        c.states.Keys.CopyTo(labels, 0);
        c.states.Values.CopyTo(values, 0);
        for (int i = 0; i < count; i++)
        {            
            states.Add(labels[i], new Vector3(values[i].x, values[i].y, values[i].z));
        }
    }

    public Vector3 getStateVector(int i)
    {
        Vector3 val = new Vector3();
        states.TryGetValue(i, out val);
        return val;
    }
}

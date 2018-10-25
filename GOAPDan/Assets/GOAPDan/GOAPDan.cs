using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAPDan {

    public static GOAPDan GOAPDanSingleton = null;

    public List<Action> possibleActions = null;

    public GOAPDan()
    {
        GOAPDanSingleton = this;
    }

    public static GOAPDan getSingleton()
    {
        if (GOAPDanSingleton == null)
            GOAPDanSingleton = new GOAPDan();
        return GOAPDanSingleton;
    }
    
}

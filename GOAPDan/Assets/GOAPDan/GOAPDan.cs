using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAPDan {

    public static GOAPDan GOAPDanSingleton = null;
    private Dictionary<string, List<Action>> actionsByEffect = null;
    public Action[] possibleActions = null;

    public GOAPDan()
    {
        GOAPDanSingleton = this;
        actionsByEffect = new Dictionary<string, List<Action>>();
    }

    public static GOAPDan getSingleton()
    {
        if (GOAPDanSingleton == null)
            GOAPDanSingleton = new GOAPDan();
        return GOAPDanSingleton;
    }
    
    private void addActionToActionsByEffect(Action a)
    {
        Dictionary<string, float> effs = a.getEffects();
        Dictionary<string, float>.KeyCollection.Enumerator stepper = effs.Keys.GetEnumerator();

        while(stepper.Current!=null)
        {
            List<Action> actions = null;
            if (!actionsByEffect.TryGetValue(stepper.Current, out actions))
            {
                actions = new List<Action>();
                actionsByEffect.Add(stepper.Current, actions);
            }
            actions.Add(a);
            if (!stepper.MoveNext())
                return;
        }
    }

    private List<Action> getActionsByEffect(string effect)
    {
        List<Action> effs = null;
        if(!actionsByEffect.TryGetValue(effect, out effs))
        {
            return new List<Action>();//return an empty list instead of null.
        }
        return effs;
    }
}

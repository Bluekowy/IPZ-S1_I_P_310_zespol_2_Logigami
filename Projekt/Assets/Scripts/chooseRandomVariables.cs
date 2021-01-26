using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseRandomVariables
{
    private int scope_min = 1;
    private int scope_max = 100;

    public chooseRandomVariables()
    {
        int var = chooseRandomVar();
    }

    public int chooseRandomVar()
    {
        int var = UnityEngine.Random.Range(scope_min, scope_max);
        Debug.Log("Randomely chosen variable:");
        Debug.Log(var);
        return var;
    }
}

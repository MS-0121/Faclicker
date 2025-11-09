using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
[CustomEditor(typeof(RecipePattern))]
#endif

public class AlloySmeltingFurnaceManager : RecipePattern
{
    // Start is called before the first frame update
    void Start()
    {
        //RecipeNumber = 0;
        //Debug.Log(RecipeNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

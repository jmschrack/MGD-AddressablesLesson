using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMeStuff : MonoBehaviour
{

    public string stuffName;
    public Transform stuffParent;
    
    public void DoItNow(){
        var stuffPrefab=Resources.Load(stuffName) as GameObject;
        GameObject.Instantiate(stuffPrefab,stuffParent);
    }
}

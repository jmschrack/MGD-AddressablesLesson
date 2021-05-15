using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class InstantiateWithType : MonoBehaviour
{
     
    public string stuffName="Stuff";
    public string betterStuffName="BetterStuff";
    public Transform stuffParent;
    
    public void DoItNow(){
        
        CardHandler stuffPrefab=Resources.Load<CardHandler>(stuffName);
        GameObject.Instantiate(stuffPrefab,stuffParent);
    }

    //THIS DOES NOT WORK!
    //Addressables are based on their file type!
    public void DoItAddrWrong(){
        var ao=Addressables.LoadAssetAsync<CardHandler>(betterStuffName);
        ao.Completed+=(handle)=>{
            CardHandler stuffPrefab=handle.Result;
            GameObject.Instantiate(stuffPrefab,stuffParent);
        };
        //Addressables.InstantiateAsync<CardHandler>(stuffName,stuffParent);
    }

    //This will work fine!
    public void DoItAddrRight(){
        var ao=Addressables.LoadAssetAsync<GameObject>(betterStuffName);
        ao.Completed+=(handle)=>{
            GameObject stuffPrefab=handle.Result;
            GameObject.Instantiate(stuffPrefab,stuffParent);
        };
        //Addressables.InstantiateAsync<CardHandler>(stuffName,stuffParent);
    }
}

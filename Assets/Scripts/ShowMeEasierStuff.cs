using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class ShowMeEasierStuff : MonoBehaviour
{
    public AssetReference stuff;
    public Transform stuffParent;
    public void DoItNow(){
        var handle=Addressables.InstantiateAsync(stuff,stuffParent);
        //If you need to check for race conditions
        if(stuff.IsDone&&!stuff.IsValid()){
            //LoadAssetAsync
        }else if(!stuff.IsDone&&stuff.IsValid()){
            //stuff.OperationHandle.Completed+=InsertCallbackHere(GameObject go)
            
        }else if(stuff.IsDone&&stuff.IsValid()){
            //GameObject go =stuff.OperationHandle.Result;
        }
        


    }
}

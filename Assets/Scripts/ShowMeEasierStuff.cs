using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class ShowMeEasierStuff : MonoBehaviour
{
    public AssetReference stuff;
    public Transform stuffParent;
    public void DoItNow(){
        Addressables.InstantiateAsync(stuff,stuffParent);
    }
}

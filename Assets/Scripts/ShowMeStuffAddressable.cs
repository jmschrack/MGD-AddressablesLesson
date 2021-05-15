using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class ShowMeStuffAddressable : MonoBehaviour
{
   

    public string stuffName;
    public Transform stuffParent;
    
    public void DoItNow(){
        Addressables.InstantiateAsync(stuffName,stuffParent);
        
    }

    
}

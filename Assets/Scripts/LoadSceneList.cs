using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
public class LoadSceneList : MonoBehaviour
{
    public AssetReferenceT<AssetList> sceneList;
    // Start is called before the first frame update
    void Start()
    {
        
        LoadList();
  
    }

    async void LoadList(){
        AssetList al=await Addressables.LoadAssetAsync<AssetList>(sceneList).Task;
        //If you made an update to a scene, make sure that scene has been moved to a Remote Load group!
        Addressables.LoadSceneAsync(al.assets[0]);
    }
   
}

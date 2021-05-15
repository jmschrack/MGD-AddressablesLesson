using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "NewAssetList", menuName = "ScriptableObjects/AssetList", order = 1)]
public class AssetList : ScriptableObject
{
    public List<AssetReference> assets;
}

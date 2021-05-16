using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
public class TextureBreaker : MonoBehaviour
{
    //public AssetReferenceT<TextureExample> textureExample;
    public AssetLabelReference theLabel;
    public Image someImage;

    public void ShowStuff(){
        var asyncOp=Addressables.LoadAssetsAsync<TextureExample>(theLabel,ProcessCallback);
        //BAD
        asyncOp.Completed+=(handle)=>{
            Debug.Log("Completed");
            Addressables.Release(asyncOp);
        };
    }

    public void ProcessCallback(TextureExample te){
        Debug.Log("Started Processing");
        someImage.sprite=Sprite.Create(te.sampleTexture,new Rect(0,0,te.sampleTexture.width,te.sampleTexture.height),Vector2.zero);
    }
}

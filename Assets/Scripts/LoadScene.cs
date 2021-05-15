using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadScene : MonoBehaviour
{

    public string sceneName;
    public float hideTime=3f;
    public Image loadWheel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene(){
        var ao=SceneManager.LoadSceneAsync(sceneName);
        ao.allowSceneActivation=false;
        float startTime=Time.timeSinceLevelLoad;
        while(ao.progress<0.9f){
            yield return 0;
            if(Time.timeSinceLevelLoad-startTime>hideTime)
                loadWheel.fillAmount=ao.progress;
        }
        ao.allowSceneActivation=true;
    }

}

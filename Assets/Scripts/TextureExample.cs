using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Example", menuName = "ScriptableObjects/TextureExample", order = 1)]
public class TextureExample : ScriptableObject
{
    public string someName;
    public Texture2D sampleTexture;
}

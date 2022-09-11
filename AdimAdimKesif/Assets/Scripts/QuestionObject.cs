using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu ( fileName =  "Question" ,menuName = "ScriptableObject/QuestionObject",order = 1) ]
public class QuestionObject : ScriptableObject {

    
    public List<SoruItem> questions;
    public int levelIndex = 0;
}
[System.Serializable]
public class SoruItem

{
    public string soru;
    public string[] cevaplar;
    public string dogrucevap;


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    //Button hangi levele götürecek.
    public int level;
    public Text textOBJ;

    
    public void LockSystem()
    {
        gameObject.GetComponent<Button>().interactable=false; //

    }

   
    public void StartLevel()
    {
        LevelMenuManager.LoadLevel(level);
    }

   public void ChangeText(string text)
   {

        textOBJ.text = text;
    }
}

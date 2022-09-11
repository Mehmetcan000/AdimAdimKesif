using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class LevelMenuManager : MonoBehaviour
{
    //public QuestionObject[] questionObject;

    public int levelCount;
    public GameObject levelPanel;
    public GameObject levelButtonPrefab;
    
    
   
    

    private void Start()
    {

        CreateLevelButtons();
        

    }

 

   
    void CreateLevelButtons()
    {

        GameObject currentButton;
        LevelButton currentLevelButton;
        for (int i = 0; i < levelCount; i++)
        {
            currentButton = Instantiate(levelButtonPrefab) as GameObject;
            currentButton.transform.SetParent(levelPanel.transform);
            currentLevelButton = currentButton.GetComponent<LevelButton>();
            currentLevelButton.level = i + 1;
            currentLevelButton.ChangeText((i+1).ToString());
            if (currentLevelButton.level > LevelData.currentLevel) //Kilit sistemini �a��rd�k levelbutton class�ndan.
            {

                currentLevelButton.LockSystem();

            }
            
            

            // Button �zerindeki text'i degistir(hangi leveldeyse)


        }
    }

    public void TurnBack()
    {

        SceneManager.LoadScene("MainMenu");

    }
    public static void LoadLevel(int level)
    {
        LevelData.currentLevel = level;
        
        SceneManager.LoadScene("Level01");

    }



}

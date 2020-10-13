using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alternative_languages : MonoBehaviour
{

    public List<GameObject> languages;

    // Start is called before the first frame update
    void Start()
    {
        UpdateLanguage();
    }

    public void UpdateLanguage(){
        //check active language
        int activeLanguage = GameObject.Find("Canvas").GetComponent<language_change>().activeLanguage;

        //disable all language prefabs
        for (int i = 0; i < languages.Count; i++){
            languages[i].SetActive(false);
        }
        
        //enable active language prefab
        languages[activeLanguage].SetActive(true);
    }

}

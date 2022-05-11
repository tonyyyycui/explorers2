using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Update_Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    Text bombText;
    int currentBombs;
    void Start()
    {
        bombText = GetComponent<Text>();
        currentBombs = 3;
    }

    // Update is called once per frame
    void Update()
    {
        bombText.text = "Bombs left: " + currentBombs;
    }
    public void decreaseBomb(){
        if (currentBombs >0){
            currentBombs -=1;
        }
    }
    public int getBombs(){
        return  currentBombs;
    }
}

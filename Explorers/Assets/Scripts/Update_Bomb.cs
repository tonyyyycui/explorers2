using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Update_Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    public Text bombText;
    public int currentBombs;
    void Start()
    {
        bombText = GameObject.Find("BombCount").GetComponent<Text>();
        currentBombs = 3;
        bombText.text = "Bombs left:" + currentBombs;
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

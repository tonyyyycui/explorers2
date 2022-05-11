using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    public Update_Bomb bombs;
    // Start is called before the first frame update
    void Start()
    {   
        GameObject bomb_ui = GameObject.Find("BombCount");
        bombs = (Update_Bomb) bomb_ui.GetComponent(typeof(Update_Bomb));
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collided with"+ other);
        if (other.gameObject.tag == "Player" && bombs.getBombs() > 0){
            //Play Block Breaking Animation


            //make breakable wall disappear
            BreakBlock(true);
            //Update Bomb UI
            bombs.decreaseBomb();
        }
    }

    void BreakBlock(bool breakable) {
        if (breakable == true){
            gameObject.SetActive(false);
        }
        else {
            gameObject.SetActive(true);
        }
    }
}

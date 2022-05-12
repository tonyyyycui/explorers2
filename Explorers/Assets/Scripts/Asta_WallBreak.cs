using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asta_WallBreak : MonoBehaviour
{
    GameObject asta;
    public Update_Bomb bombs;
    AudioSource explosion;
    // Start is called before the first frame update
    void Start()
    {
        asta = GameObject.Find("MainCharacter_Asta");
        GameObject bomb_ui = GameObject.Find("BombCount");
        bombs = (Update_Bomb) bomb_ui.GetComponent(typeof(Update_Bomb));
        explosion = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "BreakableWall" && bombs.getBombs() > 0){
            //Freeze player for a few seconds
            explosion.Play(0);
            StartCoroutine(freezePlayer());
        }
    }
        IEnumerator freezePlayer(){
        Debug.Log("Started Freeze Player Function");
        asta.GetComponent<playerBehavior>().enabled = false;
        yield return new WaitForSeconds(2);
            asta.GetComponent<playerBehavior>().enabled = true;
            Debug.Log("Ended Freeze Player Function");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asta_WallBreak : MonoBehaviour
{
    GameObject asta;
    public Update_Bomb bombs;
    AudioSource playAudio;
    public AudioClip explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        asta = GameObject.Find("MainCharacter_Asta");
        GameObject bomb_ui = GameObject.Find("BombCount");
        bombs = (Update_Bomb) bomb_ui.GetComponent(typeof(Update_Bomb));
     playAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "BreakableWall" && bombs.getBombs() > -1){
            //Freeze player for a few seconds
         playAudio.PlayOneShot(explosion, 0.7F);
            StartCoroutine(freezePlayer());
        }
    }
        IEnumerator freezePlayer(){
        Debug.Log("Started Freeze Player Function");
        asta.GetComponent<playerBehavior>().enabled = false;
        yield return new WaitForSeconds(1);
            asta.GetComponent<playerBehavior>().enabled = true;
            Debug.Log("Ended Freeze Player Function");
    }
}

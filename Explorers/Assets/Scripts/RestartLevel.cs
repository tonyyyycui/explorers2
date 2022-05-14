using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour
{
    AudioSource playAudio;
    public AudioClip restartLevelSound;
    GameObject asta;
    // Start is called before the first frame update
    void Start()
    {
        asta = GameObject.Find("MainCharacter_Asta");
        playAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)){
            playAudio.PlayOneShot(restartLevelSound,0.4F);
            StartCoroutine(restartScene());
            
        }
    }
    IEnumerator restartScene(){
        Debug.Log("Restarting Level");
        asta.GetComponent<playerBehavior>().enabled = false;
        yield return new WaitForSeconds(1);
        asta.GetComponent<playerBehavior>().enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

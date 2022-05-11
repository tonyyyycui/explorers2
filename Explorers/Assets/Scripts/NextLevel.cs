using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentScene);
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            Debug.Log("Enter Next Level" + (currentScene + 1));
            //Go Next Level
            SceneManager.LoadScene(sceneBuildIndex:(currentScene+1));
        }
    }
}

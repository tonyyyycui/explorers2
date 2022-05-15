using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collided with" + other);
        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}

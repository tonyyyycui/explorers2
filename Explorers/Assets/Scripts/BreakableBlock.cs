using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    //If in the future want to toggle from inspector:
    //[SerializeField] breakBlock = false

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collided with"+ other);
        if (other.gameObject.tag == "Player"){
            //Play Block Breaking Animation


            //make breakable wall disappear
            BreakBlock(true);
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

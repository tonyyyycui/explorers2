using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    // Start is called before the first frame update
    bool blockStatus = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player"){
            //Play Block Breaking Animation

            //Set block status to false
            blockStatus = false;

            //make breakable wall disappear
            gameObject.SetActive(false);
        }
    }
}

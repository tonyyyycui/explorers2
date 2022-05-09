using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Character_Name : MonoBehaviour
{
    [SerializeField] public GameObject displayCharacterName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("UI");
        displayCharacterName.GetComponent<Text>().text =  "Current Character Name";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbManager : MonoBehaviour
{
    private GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager")
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TouchOrb (){
        if (Input.GetMouseButton (0) == false){
            return;
        }

        gameManager.GetComponent<GameManager> ().GetOrb ();
        Destroy (this.gameObject);

    }
}

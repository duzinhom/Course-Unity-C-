using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatilhoCode : MonoBehaviour {

    public bool liberaRot;
    public GameObject ima;

	// Use this for initialization
	void Start () {

        liberaRot = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (liberaRot)
        {
            ima.gameObject.transform.Rotate(new Vector3(0, 0, 5 * Time.deltaTime));
        }
	}

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player")) 
        {
            liberaRot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            liberaRot = false;
        }
    }

}

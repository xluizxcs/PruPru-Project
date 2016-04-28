using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

    private Movimentação player;
	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<Movimentação>();
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col) {
        player.grounded = true;
    }

    void OnTriggerStay2D(Collider2D col) {
        player.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col) {
        player.grounded = false;
    }
	
}


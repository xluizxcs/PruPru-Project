using UnityEngine;
using System.Collections;

public class Impulso : MonoBehaviour {

    public Rigidbody2D pomba;
    public float forcaimpulso = 50f;

	void Start () {
        pomba = GetComponent<Rigidbody2D>(); 
    }
	

        void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Gato")
        {
            pomba.AddForce(transform.up * forcaimpulso, ForceMode2D.Impulse);
        }
    }
	
}

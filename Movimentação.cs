using UnityEngine;
using System.Collections;

public class Movimentação : MonoBehaviour
{

    public float speed = 2f;
    public float forcapulo = 130f;
    public bool grounded;
    public Rigidbody2D gato;
    public float forcaimpulso = 50f;

    void Start()
    {
        gato = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //andar
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //pular

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                transform.position += Vector3.up * speed * Time.deltaTime * forcapulo;

            }
        }
    }

        //colisão
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Pomba")
        {
            gato.AddForce(transform.up * forcaimpulso, ForceMode2D.Impulse);
        }
    }
}


    
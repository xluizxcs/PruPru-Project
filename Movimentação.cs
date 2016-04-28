using UnityEngine;
using System.Collections;

public class Movimentação : MonoBehaviour
{

    public float speed = 1.5f;
    public float forcapulo = 15f;
    public bool grounded;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //andar e pular
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //pulo
        if (Input.GetKey(KeyCode.W))
        {
                //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1 * Time.deltaTime * forcapulo));
            transform.position += Vector3.up * speed * Time.deltaTime * forcapulo;
            }
        }

        /*if (Input.GetKey(KeyCode.W))
        {
            if (grounded)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcapulo);

            }*/
        }


    
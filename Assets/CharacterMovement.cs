using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
  public float velocidad=50f;
  public GameObject characterPrincipal;
  public GameObject bala;

  private Rigidbody Físicas;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (-3.452276F, 0.1900001F, -3.704882F);

        Físicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += transform.forward * Time.deltaTime * velocidad;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position -= transform.forward * Time.deltaTime * velocidad;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += Vector3.right * Time.deltaTime;
            transform.eulerAngles += new Vector3(0,velocidad*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= Vector3.right  * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0,velocidad*Time.deltaTime,0);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            transform.position += transform.forward *velocidad * Time.deltaTime*velocidad;
        }
        if(Input.GetKey(KeyCode.Space)){
            Instantiate (bala, transform.position, transform.rotation);
        }
    }
}

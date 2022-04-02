using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
  public float velocidad=20f;
  public GameObject characterPrincipal;
  public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (-3.452276F, 0.1900001F, -3.704882F);
    }

    // Update is called once per frame
    void Update () {
        transform.position += Vector3.forward * Time.deltaTime;
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += transform.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position -= transform.forward * Time.deltaTime;
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
            transform.position += transform.forward *velocidad * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space)){
            Instantiate (bala, transform.position, transform.rotation);
        }
    }
}

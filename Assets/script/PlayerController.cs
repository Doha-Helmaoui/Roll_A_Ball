using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public Text FaceMoji;
    public Text MojiText;

    private Rigidbody rb;
    private int count;

void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetFaceMoji();
        winText.text = "";
        SetCountText();
        

    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText ();
        }
        else
        {
            other.gameObject.SetActive(false);
            count = count + 2;
            SetCountText();
        }

    }

    void SetFaceMoji ()
    {
        if (count <=8)
        {
            countText.text = "Count (._.) : " + count.ToString();
        }
        else
        { 
            countText.text = "Count (^-^) : " + count.ToString();
        }
    }

    void SetCountText ()
    {
        countText.text =  count.ToString();
        SetFaceMoji();
        if (count ==19)
        {
                winText.text = "Well Done !";
         }
     }
    
}


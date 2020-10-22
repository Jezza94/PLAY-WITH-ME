using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hannah : MonoBehaviour
{
    private float moveX;
    private float moveY;
    CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    public int speed;

    //the following GameObjects are doors that can be 'Unlocked' whenever a key with a respective tag is picked up. Add more when
    //more doors become a thing.
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0.0f);
        characterController.Move(moveDirection * Time.deltaTime);
    }


    //whenever another door needs to be added, just copy-paste the last else-if section, and adjust both the Key tag and the door 
    //GameObject to match.
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Key1"))
        {
            Destroy(col.gameObject);
            door1.SendMessage("Unlock");
        }else if (col.gameObject.CompareTag("Key2"))
        {
            Destroy(col.gameObject);
            door2.SendMessage("Unlock");
        }
        else if (col.gameObject.CompareTag("Key3"))
        {
            Destroy(col.gameObject);
            door3.SendMessage("Unlock");
        }
        else if (col.gameObject.CompareTag("Key4"))
        {
            Destroy(col.gameObject);
            door4.SendMessage("Unlock");
        }
        else if (col.gameObject.CompareTag("Key5"))
        {
            Destroy(col.gameObject);
            door5.SendMessage("Unlock");
        }
    }


}

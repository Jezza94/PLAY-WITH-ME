using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hannah : MonoBehaviour
{
    private float moveX;
    private float moveY;
    public float moveZ;
    CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    public int speed;
    public int nextScene = 2; // The number of the scene the "exit" leads to. Look under File>BuildSettings.

    //public GameObject invSlot1; // The UI display for the first item in the inventory.
    //public GameObject invSlot2;
    //bool[] hasItem = new bool[7]; // Boolean array containing inventory data. Defaults to false. Each element of the array represents 1 inventory slot.
    public AudioSource doorCreak;

    //the following GameObjects are doors that can be 'Unlocked' whenever a key with a respective tag is picked up. Add more when
    //more doors become a thing.
    public GameObject SomethingUnlocked;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //SomethingUnlocked.SetActive(false);
        // invSlot1.SetActive(false); //Hides display before item is added to inventory.
        //invSlot2.SetActive(false);
    }
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0.0f);
        characterController.Move(moveDirection * Time.deltaTime);
        Vector3 pos = transform.position;
        pos.z = moveZ;
        transform.position = pos;
        //invSlot1.SetActive(hasItem[0]); //Checks every frame for item in inventory and displays it if the boolean is true.
        //invSlot2.SetActive(hasItem[1]);
    }


    //whenever another door needs to be added, just copy-paste the last else-if section, and adjust both the Key tag and the door 
    //GameObject to match.
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene(nextScene);
        }
        if (col.gameObject.CompareTag("Key1"))
        {
            Destroy(col.gameObject);
            door1.SendMessage("Unlock");
            DoorTransition();
        }
        else if (col.gameObject.CompareTag("Key2"))
        {
            Destroy(col.gameObject);
            door2.SendMessage("Unlock");
            DoorTransition();
        }
        else if (col.gameObject.CompareTag("Key3"))
        {
            Destroy(col.gameObject);
            door3.SendMessage("Unlock");
            DoorTransition();
        }
        else if (col.gameObject.CompareTag("Key4"))
        {
            Destroy(col.gameObject);
            door4.SendMessage("Unlock");
            DoorTransition();
        }
        else if (col.gameObject.CompareTag("Key5"))
        {
            Destroy(col.gameObject);
            door5.SendMessage("Unlock");
            DoorTransition();
        }
    }

    public void DoorTransition()
    {
        doorCreak.Play();
        SomethingUnlocked.SetActive(true);
        RemoveText();
    }

    void RemoveText()
    {
        StartCoroutine(RemoveAfterSeconds(3, SomethingUnlocked));
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }


}
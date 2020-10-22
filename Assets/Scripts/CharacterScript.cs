using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    public GameObject invSlot1; // The UI display for the first item in the inventory.
    public GameObject invSlot2;
    bool[] hasItem = new bool[7]; // Boolean array containing inventory data. Defaults to false. Each element of the array represents 1 inventory slot.
    public AudioSource doorCreak;

    // Start is called before the first frame update
    void Start()
    {
        invSlot1.SetActive(false); //Hides display before item is added to inventory.
        invSlot2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        invSlot1.SetActive(hasItem[0]); //Checks every frame for item in inventory and displays it if the boolean is true.
        invSlot2.SetActive(hasItem[1]);
    }

    public void DoorTransition()
    {
        doorCreak.Play();
    }
}

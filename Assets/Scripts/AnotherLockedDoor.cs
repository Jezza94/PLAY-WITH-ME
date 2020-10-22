using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherLockedDoor : MonoBehaviour
{

    //This script is designed to be paired with the keys Hannah picks up. MAKE SURE THAT THE DOOR THIS SCRIPT IS ATTACHED TO IS BOTH THE ONE
    //THAT HAS THE COLLIDER THAT'S BLOCKING THE PATH, AND IS MENTIONED IN THE HANNAH.CS FILE
    void Unlock()
    {
        GetComponent<Collider>().enabled = false;
    }
}

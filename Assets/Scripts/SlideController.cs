using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideController : MonoBehaviour
{

    public GameObject[] slides = new GameObject[5];
    public static int tracker = 0;

    void Start()
    {
        StartCoroutine(RemoveAfterSeconds(3, slides[tracker]));
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        tracker += 1;
        if (tracker == 5)
        {
            SceneManager.LoadScene(1);
        }
        obj.SetActive(false);
        Start();
    }
}

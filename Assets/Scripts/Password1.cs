using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password1 : MonoBehaviour
{

    int password = 417;
    int i = 0;
    int input = 0;
    public Text gameText;
    bool correct = false;
    bool check = true;
    public int FailLocate;
    public int SuccLocate;


    void Update()
    {
                if (Input.GetKeyDown("1"))
                {
                    if (i == 0)
                    {
                        input += 100;
                    }
                    else if (i == 1)
                    {
                        input += 10;
                    }
                    else
                    {
                        input += 1;
                    }
                    i++;
                }
                if (Input.GetKeyDown("2"))
                {
                    if (i == 0)
                    {
                        input += 200;
                    }
                    else if (i == 1)
                    {
                        input += 20;
                    }
                    else
                    {
                        input += 2;
                    }
                    i++;
                }
                if (Input.GetKeyDown("3"))
                {
                    if (i == 0)
                    {
                        input += 300;
                    }
                    else if (i == 1)
                    {
                        input += 30;
                    }
                    else
                    {
                        input += 3;
                    }
                    i++;
                }
                if (Input.GetKeyDown("4"))
                {
                    if (i == 0)
                    {
                        input += 400;
                    }
                    else if (i == 1)
                    {
                        input += 40;
                    }
                    else
                    {
                        input += 4;
                    }
                    i++;
                }
                if (Input.GetKeyDown("5"))
                {
                    if (i == 0)
                    {
                        input += 500;
                    }
                    else if (i == 1)
                    {
                        input += 50;
                    }
                    else
                    {
                        input += 5;
                    }
                    i++;
                }
                if (Input.GetKeyDown("6"))
                {
                    if (i == 0)
                    {
                        input += 600;
                    }
                    else if (i == 1)
                    {
                        input += 60;
                    }
                    else
                    {
                        input += 6;
                    }
                    i++;
                }
                if (Input.GetKeyDown("7"))
                {
                    if (i == 0)
                    {
                        input += 700;
                    }
                    else if (i == 1)
                    {
                        input += 70;
                    }
                    else
                    {
                        input += 7;
                    }
                    i++;
                }
                if (Input.GetKeyDown("8"))
                {
                    if (i == 0)
                    {
                        input += 800;
                    }
                    else if (i == 1)
                    {
                        input += 80;
                    }
                    else
                    {
                        input += 8;
                    }
                    i++;
                }
                if (Input.GetKeyDown("9"))
                {
                    if (i == 0)
                    {
                        input += 900;
                    }
                    else if (i == 1)
                    {
                        input += 90;
                    }
                    else
                    {
                        input += 9;
                    }
                    i++;
                }
                if (Input.GetKeyDown("0"))
                {
                    input += 0;
                    i++;
                }
                if (i == 3)
        {
            StartCoroutine(TimedExit());
        }
            
       
    }

    IEnumerator TimedExit()
    {
           
        if (input == password)
        {
            correct = true;
            gameText.text = "The lock clicks open.";
        }
        else
        {
            gameText.text = "The door remains locked.";
        }
        yield return new WaitForSeconds(5);
        if (correct == true)
        {
            SceneManager.LoadScene(SuccLocate);
        }
        else
        {
            SceneManager.LoadScene(FailLocate);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour{


    public float speed;
    public float moveZ;
    bool spotted = false;
    float fasterspeed;
    private Vector3 pointAPosition;
    private Vector3 pointBPosition;
    public Transform pointA;
    public Transform pointB;
    public bool isRight;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        pointAPosition = new Vector3(pointA.position.x, pointA.position.y, 0);
        pointBPosition = new Vector3(pointB.position.x, pointB.position.y, 0);
        fasterspeed = speed * 3f;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spotted == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            Vector3 thisPosition = new Vector3(transform.position.x, transform.position.y, 0);
            if (isRight)
            {
                transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
                if (thisPosition.Equals(pointBPosition))
                {
                    //Debug.Log ("Position b");
                    isRight = false;
                    //GetComponent<SpriteRenderer>().flipX = true;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed* Time.deltaTime);
                if (thisPosition.Equals(pointAPosition))
                {
                    //Debug.Log ("Position a");
                    isRight = true;
                    //GetComponent<SpriteRenderer>().flipX = false;
                }
            }
        }
    }
   

    void FoundYou()
    {
        if (spotted == false)
        {
            StartCoroutine(Chaser());
        }
    }

    IEnumerator Chaser()
    {
        spotted = true;
        speed = 0;
        yield return new WaitForSeconds(3);
        speed = fasterspeed;

    }
}

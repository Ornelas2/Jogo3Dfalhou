using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{

    public GameObject New_Duck;
    public float speed;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, New_Duck.transform.position);
        Vector2 direction = New_Duck.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, New_Duck.transform.position, speed * Time.deltaTime);
    }
}

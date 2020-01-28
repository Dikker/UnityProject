using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;

    public float livingTime = 3f;
    void Start()
    {
        Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movent = direction.normalized * speed * Time.deltaTime;
        this.transform.position = new Vector2(transform.position.x + movent.x, transform.position.y + movent.y);

    }
}

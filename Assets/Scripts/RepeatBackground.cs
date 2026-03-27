using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; //set RepeatWidth half the size of picture, cause double picture
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < startPos.x - repeatWidth) //set background back to start pos
        {
            transform.position = startPos;
        }
    }
}

// start 43.2

//-13.2
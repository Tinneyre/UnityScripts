using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingWords : MonoBehaviour
{

    public float moveSpeed;
   
    public Text displayWord;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        transform.position = new Vector3(transform.position.x, transform.position.y + (moveSpeed * Time.deltaTime), transform.position.z);

    }
}
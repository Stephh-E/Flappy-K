
using UnityEngine;

public class kbirdscript : MonoBehaviour
{
    public Rigidbody2D myRigididbody;
    public float flapStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
        myRigididbody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}

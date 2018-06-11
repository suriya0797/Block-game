
using UnityEngine;

public class Playerplay : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 500f;
    public float sideforce = 200f;

    public Playerplay movement;
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideforce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
        
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
            movement.enabled = false;
            Debug.Log("we hit " + collision.collider.tag);
        }
    }
}
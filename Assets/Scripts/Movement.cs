using UnityEngine;

public class Movement : MonoBehaviour {

    Rigidbody2D rb2d;

    private float timer;
    private float angle;
    private float rad = 0.5f;
    private float centerx = 0;
    private float centery = 0;
    private float centerz = 0;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //rb2d.AddForce(new Vector3(3, 0, 0));
        timer += Time.deltaTime;
        angle = timer;
        //this.transform.position = new Vector3((centerx + Mathf.Sin(angle) * rad), (centery + Mathf.Cos(angle) * rad), 0);
        //rb2d.AddForce(new Vector3((centerx + Mathf.Sin(angle) * rad), (centery + Mathf.Cos(angle) * rad), 0));
        rb2d.velocity = new Vector3((centerx + Mathf.Sin(angle) * rad), (centery + Mathf.Cos(angle) * rad), 0);
    }
}

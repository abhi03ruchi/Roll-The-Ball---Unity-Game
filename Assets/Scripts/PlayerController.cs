using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    public TextMeshProUGUI countText;

    // public GameObject winTextObject;

    private float xInput;
    private float zInput;
    private float yInput;

    private int count ;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        // winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // good for handling inputs and animations
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        // movement
        Move();       
    }
    private void ProcessInputs(){
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        yInput = Input.GetAxis("Jump");
    }
    private void Move(){
        // rb.AddForce(new Vector3(xInput, 0, zInput) * moveSpeed);
        rb.AddForce(new Vector3(xInput, yInput, zInput) * moveSpeed);
    }
    private void OnTriggerEnter(Collider other){
        if( other.CompareTag("PickUp")){
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }

    void SetCountText(){
        countText.text = "Count: " + count.ToString();

        // if( count >= 12){
        //     winTextObject.SetActive(true);
        // }
    }
}

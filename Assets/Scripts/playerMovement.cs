using UnityEngine.UI;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public Rigidbody Rigidbody; //  Rigid Body Of My Object 
    public float ForceForward; //  Speed will Force To Move Forward
    public float ForceRightAndLeft_X_Axis; //  Speed will Force To Move Right or Left
    public Text  Score;

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>(); //  Get Rigid Body  Component
        Rigidbody.useGravity = false; //  Make Gravity Don't Work To  be More Smoth
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Score.text = gameObject.transform.position.z.ToString("0"); //  display  score
        
        Rigidbody.AddForce(0,0, ForceForward * Time.deltaTime); //  force cube Move Forward
        if (Input.GetKey(KeyCode.D)) //  when player kess D Key
        {
            Rigidbody.AddForce(ForceRightAndLeft_X_Axis * Time.deltaTime, 0, 0); // Force Cube Move Right
        }
        if (Input.GetKey(KeyCode.A)) //   when player kess D Key
        {
            Rigidbody.AddForce(-ForceRightAndLeft_X_Axis * Time.deltaTime, 0, 0);  //  Force Cube Move Left
        }

    }
   
}


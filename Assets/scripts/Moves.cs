using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Moves : MonoBehaviour
{
    private int count = 0;
    private string name = "Cesar Lara";
    public float timegame;
    private Rigidbody2D Object;
    private Text Text;
    private GameObject textObject;
    private GameObject Anim;
    // Start is called before the first frame update
    void Start()
    {
        this.textObject = GameObject.Find("Text");
        this.Text = this.textObject.GetComponent<Text>();
        this.Object = GetComponent<Rigidbody2D> ();
        this.Anim = GameObject.Find("Anim");
        this.Anim.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        this.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void Move(float horizontal,float vertical)
    {
        // Debug.Log(this.CanJump);
        // controllers
        // float y; 
        // controllers
        this.Object.velocity = new Vector2(horizontal * this.timegame,vertical * this.timegame);    
    }
    private void OnCollisionEnter2D(Collision2D col) {
         if (col.gameObject.name ==  "Purple") {
             this.Text.text = this.name;
             this.Anim.SetActive(false);
        }
        if (col.gameObject.name ==  "Green") {
            this.Anim.SetActive(false);
            this.count ++;
             this.Text.text = this.count.ToString();
            transform.position = (GameObject.FindGameObjectWithTag("Player").transform.position);
            //  transform.position = GameObject.FindGameObjectWithTag("Point").transform.position;
        }
        if (col.gameObject.name ==  "Blue") {
            //  this.Text.text = this.count.ToString();
            this.Anim.SetActive(true);
            //  transform.position = GameObject.FindGameObjectWithTag("Point").transform.position;
        }
    }
}

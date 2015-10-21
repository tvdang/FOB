using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

    // Use this for initialization

    /* void OnTriggerEnter2D(Collider2D other)
     {
         if (other.tag == "Player")
             Application.LoadLevel(3);
     }
     */
    /*void OnCollisionEnter(Collision coll)
    {
        Debug.Log("Collision"); //Check to see if it even registers a collision, if it works you can remove this line
        if (coll.gameObject.tag == "Enemy")
        { //sees if the object your player collided with has a tag called "Enemy", this can be replaced with if(coll.gameobject.name == ... but using a tag is an easy way to do it.
          //Add your code here, like:
            Application.LoadLevel(3);    //Replace "GameOver" with your scene you want to load
            Debug.Log("Working");  //if working, you can remove this line.
        }*/

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Collision");
        if (coll.gameObject.tag == "Enemy")
        {
            Application.LoadLevel(3);
        }
    }
}
    //void OnTriggerEnter() { Application.LoadLevel(3); } //C#
  
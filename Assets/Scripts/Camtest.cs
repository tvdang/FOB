using UnityEngine;
using System.Collections;

public class Camtest : MonoBehaviour {

    public GameObject Player;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {

        //Subtract player differnce between cam and player aka distance between two
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame

    //We use LateUpdate cause it gets called after Update, so we know player has moved in Update to follow player
    void LateUpdate()
    {

        //Move camera alligned with player ignoreing rotation 
        transform.position = Player.transform.position + offset + new Vector3(0f, Player.transform.localScale.y, 0f);


    }
}

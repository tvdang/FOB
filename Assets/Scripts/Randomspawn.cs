using UnityEngine;
using System.Collections;

public class Randomspawn : MonoBehaviour
{
    public float timer = 0.0f;

    public Transform swap1;
    public Transform swap2;
    public Transform swap3;

    public Transform location;

    public GameObject go;

    public GameObject myPrefab;

    void Start()
    {

    }

    void Update()
    {

        timer += Time.deltaTime;
        //Debug.Log(timer);
        if (timer >= 2)

            Swap();

    }

    void Swap()
    {
        timer = 0;

        int randomPick = Mathf.Abs(Random.Range(1, 4));

        if (randomPick == 1)
        {
            location = swap1;
            Debug.Log("Pos 1");
        }

        if (randomPick == 2)
        {
            location = swap2;
            Debug.Log("Pos 2");
        }

        if (randomPick == 3)
        {
            location = swap3;
            Debug.Log("Pos 3");
        }

        go = Instantiate(myPrefab, location.position, location.rotation) as GameObject;

        GetComponent<Rigidbody>().AddForce(location.forward * 100f);
    }
}

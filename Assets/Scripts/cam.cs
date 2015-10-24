using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {

    public Transform target;

    [System.Serializable]
    public class PositionSettings
    {
        //distance from out target
        //bool for zooing and smoothfollowing
        // min and max zoom settings

        public float distanceFromTarget = -50;
        public bool allowZoom = true;
        public float zoomSmooth = 100;
        public float zoomStep = 2;
        public float maxZoom = -30;
        public float miinZoom = -60;
        public bool smoothFollow = true;
        public float smooth = 0.5f;
        [HideInInspector]
        public float newDistance = -50;
    }
    [System.Serializable]
    public class OrbitSettings
    {
        //holding our current x and y rotation for out camera
        //bool for allowing orbit
        public float xRotation = -65;
        public float yRotation = -180;
        public bool allowOrbit = true;
        public float yOrbitSmooth = 0.5f;
    }
    [System.Serializable]
    public class InputSettings
    {
        public string MOUSE_ORBIT = "MouseOrbit";
        public string ZOOM = "Mouse ScrollWheel";
    }
    public PositionSettings position = new PositionSettings();
    public OrbitSettings orbit = new OrbitSettings();
    public InputSettings input = new InputSettings();


    Vector3 destination = Vector3.zero;
    Vector3 camVelocity = Vector3.zero;
    Vector3  currentMousePosition = Vector3.zero;
    Vector3 previousMousePosition = Vector3.zero;

    float mouseOrbitInput, zoomInput;

    void Start()
    {
        //setting camera target
        SetCameraTarget(target);
        if (target)
        {
            MoveToTarget();
        }
    }

    public void SetCameraTarget(Transform t)
    {
        // if we want to set a new target at runtime
        target = t;
        if (target == null)
        {
            Debug.LogError("your camera needs a target");
        }
    }

    void GetInput()
    {
        //filling the value for our input variables
        mouseOrbitInput = Input.GetAxisRaw(input.MOUSE_ORBIT);
        zoomInput = Input.GetAxisRaw(input.ZOOM);
    }
    void Update()
    {
        //getting input and zooming
        GetInput();
        if(position.allowZoom)
        {
            ZoomInOnTarget();
        }
    }

    void FixedUpdate()
    {
        //move to target
        //look at target
        //orbit
        if(target)
        {
            MoveToTarget();
            LookAtTarget();
            MouseOrbitTarget();
        }
    }
    void MoveToTarget()
    {
        //handling getting our camera to its destination position
        destination = target.position;
        destination += Quaternion.Euler(orbit.xRotation, orbit.yRotation, 0)*-Vector3.forward * position.distanceFromTarget;
        if (position.smoothFollow)
        {
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref camVelocity, position.smooth);
        }
        else
            transform.position = destination;
    }
    void LookAtTarget()
    {
        //handling getting our camera to look at the target at all times
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = targetRotation;
    }
    void MouseOrbitTarget()
    {
        //getting the camera to orbit around our character
    }
    void ZoomInOnTarget()
    {
        //modifying the distancefromtarget to be closer or further away from our target
    }

}

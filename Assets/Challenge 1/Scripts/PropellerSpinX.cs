using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    public float rotationSpeed;
    private Vector3 spin = new Vector3(0, 0, 100);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin * Time.deltaTime * rotationSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class GroundPlaneBehaviour : MonoBehaviour {

    public void show() {
        Debug.Log("Found!!");
        this.transform.localPosition = new Vector3(0f, 0.025f, 0f);
        this.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}

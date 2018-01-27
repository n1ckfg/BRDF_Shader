using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public Vector3 rot;

	private void Update() {
        transform.Rotate(rot);
	}

}

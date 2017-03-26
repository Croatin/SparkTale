using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canJump : MonoBehaviour {

    void OnCollisionStay(Collision col)
    {
        GameObject.FindObjectOfType<playerController>().canJump = true;
    }
}

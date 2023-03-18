using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject player;
    Walk walk;

    private void Awake()
    {
        walk = player.GetComponent<Walk>();
    }

    // -------------------
    // METHODS
    // -------------------
    // CREATE A WALK METHOD
    // CREATE A JUMP METHOD
    // CREATE A CLIMB METHOD
    // CREATE A RUN METHOD
    // CREATE AN EAT METHOD
    // CREATE A FLY METHOD
    // -------------------
    // POSSIBLE SYSTEMS
    // -------------------
    // CREATE A NEEDS SYSTEM
    // CREATE A COMBAT SYSTEM
}

﻿using UnityEngine;

// This script controls how the Barrel Object reacts when the player hits it with the sword.

// This script is attached to Knight_Barrel

public class Knight_Barrel : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D[] rb2D;  // Array to contain objects with a rigidbody attached
    public float thrust = 500f;
    public GameObject[] loots;  // Array to contain objects

    public void BreakBarrel(float xAmount, float yAmount)
    {
        Vector2 m_force = new Vector2(xAmount, yAmount) * thrust;   // This determines the amount of force to apply to the rigidbody

        // This for loop activates the sprite renderer of all objects in the loop
        for (int i = 0; i < loots.Length; i++)
        {
            loots[i].SetActive(true);
        }

        // This for loop applies a force to all objects in the loop
        for (int i = 0; i < loots.Length; i++)
        {
            rb2D[i].AddForce(m_force);
        }

        animator.SetTrigger("break"); //  Activates trigger for Barrel destruction animation
        Knight_SoundManager.PlaySound("Knight_Barrel"); // Activates sound for Barrel destruction
        Destroy(gameObject, .5f); // Destroys the game object from the scene
    }
}

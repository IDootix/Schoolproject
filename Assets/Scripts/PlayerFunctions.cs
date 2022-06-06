using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class PlayerFunctions : MonoBehaviour
{

    // public void EstimatePlaytime()
    // {
    //     // Estimate the playtime of the player
    //     // This is a very simple function that just adds up the time spent in each scene
    //     // and outputs the result to the console.
        
    //     float totalPlaytime = 0;

    //     foreach (float playtime in GameManager.instance.playtime)
    //     {
    //         totalPlaytime += playtime;
    //     }
		
    //     Console.WrtieLine("Total playtime: " + totalPlaytime + " seconds");
    // }

    // public void SaveGame()
    // {
    //     // Save the game
    //     // This is a very simple function that just saves the current playtime of each scene
    //     // to the GameManager.instance.playtime array.
    //     // The GameManager.instance.playtime array is then saved to a file.
        
    //     for (int i = 0; i < GameManager.instance.playtime.Length; i++)
    //     {
    //         GameManager.instance.playtime[i] = GameManager.instance.playtime[i] + Time.timeSinceLevelLoad;
    //     }

    //     GameManager.instance.Save();
    // }

    // public void LoadGame()
    // {
    //     // Load the game
    //     // This is a very simple function that just loads the current playtime of each scene
    //     // from the GameManager.instance.playtime array.
    //     // The GameManager.instance.playtime array is then loaded from a file.
        
    //     GameManager.instance.Load();
    // }

    /* public void Jetpack()
    {
        // Enable the jetpack
        // This is a very simple function that enables the jetpack and disables the gravity
        // of the player.
        
        GetComponent<CharacterController>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Jetpack>().enabled = true;
    }

    public void NormalMovement()
    {
        // Enable the normal movement
        // This is a very simple function that enables the gravity
        // of the player and disables the jetpack.
        
        GetComponent<CharacterController>().enabled = true;
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Jetpack>().enabled = false;
    } */
    /* public void Controls()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            EstimatePlaytime();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            SaveGame();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            LoadGame();
        } */

       /*  if (Input.GetKeyDown(KeyCode.F4))
        {
            Jetpack();
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            NormalMovement();
        } */
    //}
}

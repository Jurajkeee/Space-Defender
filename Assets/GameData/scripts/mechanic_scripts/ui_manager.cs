﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_manager : MonoBehaviour {
    public singletone_script singletone;

    public void Pause_Game()
    {
        singletone.tempSpeed = singletone.playerSpeed;
        singletone.playerSpeed = 0;
        singletone.shootingPS.SetActive(false);
        singletone.disable_control = true;
    }
    public void Continue_Game()
    {
        singletone.playerSpeed = singletone.tempSpeed;
        singletone.level_complete_canvas.enabled = false;
        singletone.shootingPS.SetActive(true);
        singletone.disable_control = false;
    }
    public void Start_Game()
    {
        Debug.Log("Start Game");
        singletone.playerSpeed = singletone.tempSpeed;
        singletone.main_menu_canvas.enabled = false;
        singletone.shootingPS.SetActive(true);
        singletone.disable_control = false;
    }
    public void Level_Complete_Window()
    {
        singletone.player_info.level++;
        singletone.nextLevelText.text = singletone.player_info.level.ToString();
        singletone.level_complete_canvas.enabled = true;
        Pause_Game();
    }
    public void LevelEnded()
    {
        Debug.Log("Level Ended");
    }
    private void Update()
    {

        singletone.scoreUI.text = singletone.player_info.score.ToString();
        singletone.highscoreUI.text = "your highscore: " + singletone.player_info.highscore.ToString();

    }
}

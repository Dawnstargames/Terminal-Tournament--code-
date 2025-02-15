﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
   [SerializeField] Canvas gameOverCanvas = null;

   private void Awake() {
       gameOverCanvas.enabled = false;
   }

   public void HandleDeath()
   {
       gameOverCanvas.enabled = true;
       Time.timeScale = 0;
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
   }
}

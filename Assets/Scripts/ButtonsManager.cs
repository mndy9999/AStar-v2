﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{

    public Button[] buttons;
    public Button activeButton;

    public void setActiveMoutain() { activeButton = (activeButton == buttons[0]) ? null : buttons[0]; }
    public void setActiveWater() { activeButton = (activeButton == buttons[1]) ? null : buttons[1]; }
    public void setActiveSwamp() { activeButton = (activeButton == buttons[2]) ? null : buttons[2]; }
    public void setActiveHammer() { activeButton = (activeButton == buttons[3]) ? null : buttons[3]; }

    private void Update()
    {
        if(activeButton) Cursor.SetCursor(activeButton.image.sprite.texture, Vector3.zero, CursorMode.Auto);
    }

    public Button getActiveButton() { return activeButton; }
}

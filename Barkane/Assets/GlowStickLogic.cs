using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowStickLogic : MonoBehaviour
{
    public int lifetime = 4; //the number of folds this glowstick will be active for
    public GlowstickState state = GlowstickState.PRIMED;
    public BoxCollider box1;
    public BoxCollider box2;

    //called whenever the joint the glowstick is on is folded;
    public void OnFold()
    {
        if(state == GlowstickState.OFF);
        if(state == GlowstickState.CRACKED)
        {
            lifetime--;
            if(lifetime == 0)
            {
                state = GlowstickState.OFF;
                ToggleGSBoxes(false);
            }
        }
        if(state == GlowstickState.PRIMED)
        {
            state = GlowstickState.CRACKED;
            ToggleGSBoxes(true);
        }
    }

    //toggles the boxes which activate the crystals;
    public void ToggleGSBoxes(bool toggle)
    {
        box1.enabled = toggle;
        box2.enabled = toggle;
    }
}

public enum GlowstickState {
    PRIMED,
    CRACKED,
    OFF,
}
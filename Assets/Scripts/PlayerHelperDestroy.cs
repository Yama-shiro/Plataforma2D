using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelperDestroy : MonoBehaviour
{
    public Player player;

    public void KillPlayer()
    {
        player.DestroyMe();
    }
}

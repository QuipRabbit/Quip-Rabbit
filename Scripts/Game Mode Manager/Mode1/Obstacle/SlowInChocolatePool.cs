// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using System.Collections.Generic;
using UnityEngine;

public class SlowInChocolatePool : MonoBehaviour
{
    private float slowMultiplier = 0.5f;

    private HashSet<GameObject> affectedObjects = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (affectedObjects.Contains(other.gameObject)) return;

        if (other.TryGetComponent<PlayerControl>(out var player))
        {
            player.SetSpeedMultiplier(slowMultiplier);
            affectedObjects.Add(other.gameObject);
        }
        else if (other.TryGetComponent<BotMovement>(out var bot))
        {
            bot.SetSpeedMultiplier(slowMultiplier);
            affectedObjects.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!affectedObjects.Contains(other.gameObject)) return;

        if (other.TryGetComponent<PlayerControl>(out var player))
        {
            player.SetSpeedMultiplier(1f);
        }
        else if (other.TryGetComponent<BotMovement>(out var bot))
        {
            bot.SetSpeedMultiplier(1f);
        }

        affectedObjects.Remove(other.gameObject);
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

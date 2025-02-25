// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    [SerializeField] private GameObject[] _characterGameOBjects;
    private int _activeIndex = 0;

    public void ChangeCharacterCostumeSet(int index)
    {
        if (index < 0 || index > _characterGameOBjects.Length) return;

        // Deactivate all objects
        foreach (GameObject obj in _characterGameOBjects)
        {
            obj.SetActive(false);
        }

        // Activate the selected object
        _characterGameOBjects[index].SetActive(true);
        _activeIndex = index;
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

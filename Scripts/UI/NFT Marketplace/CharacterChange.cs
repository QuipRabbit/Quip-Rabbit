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

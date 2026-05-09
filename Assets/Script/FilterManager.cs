using UnityEngine;

public class FilterManager : MonoBehaviour
{
    public GameObject[] chestExercises;
    public GameObject[] backExercises;
    public GameObject[] legExercises;
    public GameObject[] shoulderExercises;
    public GameObject[] armExercises;

    void Start()
    {
        HideAll();
    }

    public void ShowChest() { HideAll(); foreach (var obj in chestExercises) obj.SetActive(true); }
    public void ShowBack() { HideAll(); foreach (var obj in backExercises) obj.SetActive(true); }
    public void ShowLegs() { HideAll(); foreach (var obj in legExercises) obj.SetActive(true); }
    public void ShowShoulders() { HideAll(); foreach (var obj in shoulderExercises) obj.SetActive(true); }
    public void ShowArms() { HideAll(); foreach (var obj in armExercises) obj.SetActive(true); }

    void HideAll()
    {
        foreach (var obj in chestExercises) obj.SetActive(false);
        foreach (var obj in backExercises) obj.SetActive(false);
        foreach (var obj in legExercises) obj.SetActive(false);
        foreach (var obj in shoulderExercises) obj.SetActive(false);
        foreach (var obj in armExercises) obj.SetActive(false);
    }
}



using UnityEngine;
using TMPro;

public class WorkoutDisplay : MonoBehaviour
{
    public TextMeshProUGUI row1;
    public TextMeshProUGUI row2;
    public TextMeshProUGUI row3;
    public TextMeshProUGUI row4;
    public TextMeshProUGUI row5;

    void Start()
    {
        row1.text = "-";
        row2.text = "-";
        row3.text = "-";
        row4.text = "-";
        row5.text = "-";

        if (DataManager.workoutList.Count > 0) row1.text = DataManager.workoutList[0];
        if (DataManager.workoutList.Count > 1) row2.text = DataManager.workoutList[1];
        if (DataManager.workoutList.Count > 2) row3.text = DataManager.workoutList[2];
        if (DataManager.workoutList.Count > 3) row4.text = DataManager.workoutList[3];
        if (DataManager.workoutList.Count > 4) row5.text = DataManager.workoutList[4];
    }
}
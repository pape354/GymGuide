using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AddtoWorkout : MonoBehaviour
{
    public string exerciseName;
    public string sets;
    public string reps;
    public TextMeshProUGUI counterText;

    public void OnAddClicked()
    {
        DataManager.AddExercise(exerciseName, sets, reps);

        int count = DataManager.workoutList.Count;

        if (counterText != null)
            counterText.text = count + " /5 added";

        Debug.Log("Added: " + exerciseName); 

        if (count >= 5)
        {
           
           SceneManager.LoadScene("WorkoutScene");
        }
    }
}

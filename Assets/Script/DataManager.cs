

using UnityEngine;
using System.Collections.Generic;

public class DataManager : MonoBehaviour
{
    public static List<string> workoutList = new List<string>();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void AddExercise(string name, string sets, string reps)
    {
        string exercise = name + " " + sets + "x" + reps;
        workoutList.Add(exercise);
        Debug.Log("Added: " + exercise);
    }

    public static void ClearWorkout()
    {
        workoutList.Clear();
        Debug.Log("Workout cleared");
    }
    public void ClearWorkoutButton()
    {
        workoutList.Clear();
        
        Debug.Log("Workout cleared");
    }
}
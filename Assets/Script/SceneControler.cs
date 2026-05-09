using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Loads the Home Screen
    public void LoadHome() { SceneManager.LoadScene("HomeScene"); }
    // Loads the Equipment Search Screen
    public void LoadSearch() { SceneManager.LoadScene("SearchScene"); }
    // Loads the Exercise Detail Screen
    public void LoadDetail() { SceneManager.LoadScene("DetailScene"); }
    // Loads the Workout Template Screen
    public void LoadWorkout() { SceneManager.LoadScene("WorkoutScene"); }
    // Loads the initial Splash Screen
    public void LoadSplash() { SceneManager.LoadScene("SplashScene"); }

    // Back navigation
    public void BackToSplash() { SceneManager.LoadScene("SplashScene"); }
    public void BackToHome() { SceneManager.LoadScene("HomeScene"); }
    public void BackToSearch() { SceneManager.LoadScene("SearchScene"); }
    public void BackToDetail() { SceneManager.LoadScene("DetailScene"); }
}
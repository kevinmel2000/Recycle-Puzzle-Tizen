using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverControl : MonoBehaviour
{
    public Text score;

    // Use this for initialization
    private void Start()
    {
        score.text = Data.Score.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void Ulangi()
    {
        Data.Score = 0;
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }
}
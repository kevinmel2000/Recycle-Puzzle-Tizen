using UnityEngine;
using UnityEngine.UI;

public class BoxTrash : MonoBehaviour
{
    public AudioClip audioCorrect;
    public AudioClip audioWrong;
    private AudioSource asCorrect;
    private AudioSource asWrong;

    [SerializeField]
    private Text txtScore;
    public GameObject detect;

    // Use this for initialization
    private void Start()
    {
        asCorrect = gameObject.AddComponent<AudioSource>();
        asCorrect.clip = audioCorrect;

        asWrong = gameObject.AddComponent<AudioSource>();
        asWrong.clip = audioWrong;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(!Input.GetMouseButton(0))
        {
            Destroy(collision.gameObject);
            Debug.Log(" c " + collision.name + " & " + detect.name);

            if(collision.name.Contains(detect.name))
            {
                Data.Score += 10;
                txtScore.text = Data.Score.ToString();
                asCorrect.Play();
            }
            else
            {
                asWrong.Play();
            }
        }
    }
}
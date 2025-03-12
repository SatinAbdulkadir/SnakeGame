using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //food

    /*public BoxCollider2D gridArea;


    private void Start()
    {
        RandomizePosition();
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0);



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            RandomizePosition();

        }
    }*/
    ///////////////////////////////////////////////////////
    //snake
    /*private Vector2 _direction = Vector2.right;

    private List<Transform> _segments = new List<Transform>();

    public Transform segmentPrefab;

    [SerializeField] private int initialSize;

    private void Start()
    {
        ResetState();
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        }


    }

    private void FixedUpdate()
    {

        for (int i = _segments.Count - 1; i > 0; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }

        this.transform.position = new Vector3
            (
            Mathf.Round(this.transform.position.x) + _direction.x,
             Mathf.Round(this.transform.position.y) + _direction.y,

            0.0f
            );


    }

    public void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);


    }

    private void ResetState()
    {
        for (int i = 1; i < _segments.Count; i++)
        {
            Destroy(_segments[i].gameObject);


        }
        _segments.Clear();
        _segments.Add(this.transform);

        for (int i = 1; i < this.initialSize; i++)
        {
            _segments.Add(Instantiate(this.segmentPrefab));
        }

        this.transform.position = Vector3.zero;


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Grow();
        }
        else if (other.tag == "Obstacle")
        {
            ResetState();
        }

    }*/
    //-------------------------------------------------------
    //mainmenu

    // Start is called before the first frame update
  /* void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void OnButtonClick()
    {
        playGame();

    }

    */




    //***************************************08092024**********************************
}

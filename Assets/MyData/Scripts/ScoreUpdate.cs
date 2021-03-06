using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    private ScoreManager _manager;

    [SerializeField] private TextMeshProUGUI _scoreTxt;
    [SerializeField] private TextMeshProUGUI _livesTxt;
    [SerializeField] private TextMeshProUGUI _endScore;


    void Start()
    {
        _manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreManager>();
    }


    void Update()
    {
        _scoreTxt.text = ""+_manager.GetScore();
        _livesTxt.text = ""+_manager.GetLives();

        if (_endScore != null)
        {
            _scoreTxt.text = "" + _manager.GetScore();
        }
    }
}

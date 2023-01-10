using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BoxManager : MonoBehaviour
{

    public static BoxManager InstanceBoxManager;
    private GameObject[] _tabBox;

    [SerializeField]
    private BoxScriptableObject _boxData;
    [SerializeField] 
    private TextMeshProUGUI _text;
    
    private int numberOfBox;

    void Awake()
    {
        InstanceBoxManager = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        numberOfBox = _boxData.numberOfBox;
        
        //Fait apparaître les Box dans les zones d'apparation
        _tabBox = GameObject.FindGameObjectsWithTag("Box");
        Debug.Log(_tabBox.Length);
        var random = new System.Random();
        _tabBox = _tabBox.OrderBy(box => random.Next()).ToArray();
        for (int i = numberOfBox; i < _tabBox.Length; i++)
        {
            _tabBox[i].SetActive(false);
        }
        
        //Affiche le nombre de box à détruire dans l'UI
        _text.text = "Caisse restantes : " + numberOfBox;

    }

    public void ABoxIsDestroyed()
    {
        numberOfBox--;
        Debug.Log("Une box a été détruite");
        if (numberOfBox == 0)
        {
            LevelManager.InstanceLevelManager.OpenTheGate();
            
        }
        ChangeText();
        
        
    }

    void ChangeText()
    {
        if (numberOfBox <= 0)
        {
            _text.text = "La porte est ouverte !";
        }
        else
        {
            _text.text = "Caisse restantes : " + numberOfBox;
        }
    }
}


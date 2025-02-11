using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuDuPoisson : MonoBehaviour
{
   [SerializeField] private int _poidsPOrange = 10;

   [SerializeField] private float _poidsPBleu = 10;
    
    [SerializeField] private GameObject _lePoissonOrange;

    [SerializeField] private GameObject _lePoissonBleu;

    // Start is called before the first frame update
    void Start()
    {
    }   

    // Update is called once per frame
    void Update()
    {
         if(_poidsPOrange > _poidsPBleu)
        {
           //Debug.Log(_poidsPOrange);
           _lePoissonBleu.SetActive(false);
        }
        else if(_poidsPOrange < _poidsPBleu)
        {
            _lePoissonOrange.SetActive(false);
            //Debug.Log("ben nonnnn");
        }
        
        // Debug.Log(_poidsPOrange);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{

    public GameObject UIScreen;
    public GameObject player;
    public GameObject gameMan;

    // Start is called before the first frame update
    void Awake()
    {
        if(UIFade.instance == null)
        {
            //UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
            Instantiate(UIScreen);
        }

        if (PlayerController.instance == null)
        {
            Instantiate(player);
            //PlayerController clone = Instantiate(player).GetComponent<PlayerController>();
            //PlayerController.instance = clone;
        }

        if(GameManger.instance == null)
        {
            Instantiate(gameMan);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

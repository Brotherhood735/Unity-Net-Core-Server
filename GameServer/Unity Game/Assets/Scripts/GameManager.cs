using System.Collections;
using System.Collections.Generic;
using Scripts;
using SharedLibrary;
using UnityEngine;
using System.Threading.Tasks;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var player = await HttpClient.Get<Player>("https://localhost:7068/player/500");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

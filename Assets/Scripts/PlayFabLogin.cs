using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System.Threading.Tasks;

public class PlayFabLogin : MonoBehaviour
{
    async void Start()
    {
        PlayFabSettings.staticSettings.TitleId = "CBFDA";

        var request = new LoginWithCustomIDRequest
        {
            CustomId = "GettingStartedGuide",
            CreateAccount = true
        };

        var result = await PlayFabClientAPI.LoginWithCustomIDAsync(request);

        var message = result.Error is null ? $"Login success! My PlayFabID is {result.Result.PlayFabId}" : result.Error.GenerateErrorReport();

        Debug.Log(message);
    }
}

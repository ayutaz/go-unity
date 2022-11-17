using System.Net.Http;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GetClient : MonoBehaviour
{
    private HttpClient _httpClient;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private Button getButton;

    private void Start()
    {
        getButton.OnClickAsAsyncEnumerable()
            .Subscribe(async _ => { textMeshProUGUI.text = await GetData(); }).AddTo(this);
    }

    private async UniTask<string> GetData()
    {
        using var req = UnityWebRequest.Get("localhost:8090/hello");
        await req.SendWebRequest();
        return req.downloadHandler.text;
    }
}
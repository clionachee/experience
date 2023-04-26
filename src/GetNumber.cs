using System.Collections;
using Web3Unity.Scripts.Library.Ethers.Contracts;
using Web3Unity.Scripts.Library.Ethers.Providers;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

// Define the GetNumber class, responsible for fetching and displaying a random number from a smart contract
public class GetNumber : MonoBehaviour
{
    public Text randomNumber; // Reference to the Text component where the random number will be displayed
    [SerializeField] private float updateInterval = 1f; // Interval to update the random number

    private void Start()
    {
        // Start the FetchNumberRoutine coroutine
        StartCoroutine(FetchNumberRoutine());
    }

    // Coroutine to fetch the random number at regular intervals
    private IEnumerator FetchNumberRoutine()
    {
        while (true)
        {
            // Fetch the random number and wait for the result
            yield return FetchNumber();

            // Wait for the specified update interval
            yield return new WaitForSeconds(updateInterval);
        }
    }

    // Async method to fetch the random number from the smart contract
    private async Task FetchNumber()
    {
        // Get the current network ID and the corresponding network configuration
        int networkId = Web3GL.Network();
        NetworkConfig networkConfig = ConfigManager.GetNetworkConfig(networkId);

        if (networkConfig == null)
        {
            Debug.LogError("No network configuration found for network ID: " + networkId);
            return;
        }

        // Define the contract ABI, contract address, and the method to call
        string contractAbi = "[{ \"inputs\":[],\"name\":\"getRandomNumber\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";
        string contractAddress = networkConfig.contractAddress;
        string method = "getRandomNumber";

        // Create a JSON-RPC provider and a contract instance
        var provider = new JsonRpcProvider(networkConfig.rpc);
        var contract = new Contract(contractAbi, contractAddress, provider);

        // Call the getRandomNumber method in the smart contract
        var calldata = await contract.Call(method, new object[]
        {
            // If you need to add parameters you can do so, a call with no args is blank
            // arg1,
            // arg2
        });

        // Update the random number Text component with the fetched value
        randomNumber.text = calldata[0].ToString();
        Debug.Log("Contract Variable Total: " + calldata[0]);
    }
}

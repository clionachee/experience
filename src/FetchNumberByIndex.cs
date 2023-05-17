using UnityEngine;
using UnityEngine.UI;
using Web3Unity.Scripts.Library.Ethers.Contracts;
using Web3Unity.Scripts.Library.Ethers.Providers;
using System.Threading.Tasks;

public class FetchNumberByIndex : MonoBehaviour
{
    public InputField indexInputField; // Reference to the InputField component where the index will be input
    public Button submitButton; // Reference to the Button component which will trigger the fetch operation
    public Text randomNumber; // Reference to the Text component where the random number will be displayed

    private void Start()
    {
        // Add a listener to the Button component to call the FetchNumber method when clicked
        submitButton.onClick.AddListener(async delegate { await FetchNumber(); });
    }

    private async Task FetchNumber()
    {
        // Get the index from the InputField component
        uint index;
        if (!uint.TryParse(indexInputField.text, out index))
        {
            Debug.LogError("Invalid index: " + indexInputField.text);
            return;
        }

        // Get the current network ID and the corresponding network configuration
        int networkId = Web3GL.Network();
        NetworkConfig networkConfig = ConfigManager.GetNetworkConfig(networkId);

        if (networkConfig == null)
        {
            Debug.LogError("No network configuration found for network ID: " + networkId);
            return;
        }

        // Define the contract ABI, contract address, and the method to call
        string contractAbi = "[{ \"inputs\":[{\"internalType\":\"uint256\",\"name\":\"index\",\"type\":\"uint256\"}],\"name\":\"getRandomNumberByRequestIdIndex\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";
        string contractAddress = networkConfig.contractAddress;
        string method = "getRandomNumberByRequestIdIndex";

        // Create a JSON-RPC provider and a contract instance
        var provider = new JsonRpcProvider(networkConfig.rpc);
        var contract = new Contract(contractAbi, contractAddress, provider);

        // Call the getRandomNumberByRequestIdIndex method in the smart contract
        var calldata = await contract.Call(method, new object[] { index });

        // Update the random number Text component with the fetched value
        randomNumber.text = calldata[0].ToString();
        Debug.Log("Contract Variable Total: " + calldata[0]);
    }
}

using UnityEngine;
using System.Numerics;
using Newtonsoft.Json;

#if UNITY_WEBGL
public class ApproveVRFConsumer : MonoBehaviour
{
    async public void Approve()
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
        string contractAbi = "[{ \"constant\":false, \"inputs\":[{\"name\":\"_spender\",\"type\":\"address\"},{\"name\":\"_value\",\"type\":\"uint256\"}], \"name\":\"approve\", \"outputs\":[{\"name\":\"\",\"type\":\"bool\"}], \"payable\":false, \"stateMutability\":\"nonpayable\", \"type\":\"function\" }]";
        string contractAddress = networkConfig.linkTokenAddress; // Address of the LINK token contract
        string method = "approve";

        // Define the spender address and the amount to approve
        string spenderAddress = networkConfig.contractAddress; // Address of the VRF consumer contract
        BigInteger amountToApprove = BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639935"); // Maximum possible value

        // Serialize the method arguments
        string[] args = { spenderAddress, amountToApprove.ToString() };
        string serializedArgs = JsonConvert.SerializeObject(args);

        // Send the transaction
        string response = await Web3GL.SendContract(method, contractAbi, contractAddress, serializedArgs, "0", "", "");
        
        Debug.Log("Transaction response: " + response);
    }
}
#endif

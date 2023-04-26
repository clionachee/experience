using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The RequestVRF class is only compiled and used for the WebGL platform
#if UNITY_WEBGL
public class RequestVRF : MonoBehaviour
{
    // Method to request a random number using VRF (Verifiable Random Function)
    async public void RequestRandomNumber()
    {
        // Get the current network ID and the corresponding network configuration
        int networkId = Web3GL.Network();
        NetworkConfig networkConfig = ConfigManager.GetNetworkConfig(networkId);

        if (networkConfig == null)
        {
            Debug.LogError("No network configuration found for network ID: " + networkId);
            return;
        }

        // Define the smart contract method to call, ABI, contract address, and other parameters
        string method = "requestRandomWords";
        string abi = "[ {\"inputs\":[],\"name\":\"requestRandomWords\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"requestId\",\"type\":\"uint256\"}],\"stateMutability\":\"nonpayable\",\"type\":\"function\"} ]";
        string contractAddress = networkConfig.contractAddress;
        string args = "[]";
        string value = "0";
        string gasLimit = ""; // Optional gas limit
        string gasPrice = ""; // Optional gas price

        // Connect to the user's browser wallet (e.g., MetaMask) to update the contract state
        try
        {
            string response = await Web3GL.SendContract(method, abi, contractAddress, args, value, gasLimit, gasPrice);
            Debug.Log(response);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
}
#endif

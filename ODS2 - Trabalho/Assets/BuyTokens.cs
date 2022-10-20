using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

#if UNITY_WEBGL
public class BuyTokens : MonoBehaviour
{
    async public void OnSendContract()
    {
        // smart contract method to call
        string method = "addTotal";
        // abi in json format
        string abi = "[ \t{ \t\t\\\"inputs\\\": [], \t\t\\\"name\\\": \\\"buyTokens\\\", \t\t\\\"outputs\\\": [ \t\t\t{ \t\t\t\t\\\"internalType\\\": \\\"uint256\\\", \t\t\t\t\\\"name\\\": \\\"tokenAmount\\\", \t\t\t\t\\\"type\\\": \\\"uint256\\\" \t\t\t} \t\t], \t\t\\\"stateMutability\\\": \\\"payable\\\", \t\t\\\"type\\\": \\\"function\\\" \t}, \t{ \t\t\\\"inputs\\\": [ \t\t\t{ \t\t\t\t\\\"internalType\\\": \\\"address\\\", \t\t\t\t\\\"name\\\": \\\"tokenAddress\\\", \t\t\t\t\\\"type\\\": \\\"address\\\" \t\t\t} \t\t], \t\t\\\"stateMutability\\\": \\\"nonpayable\\\", \t\t\\\"type\\\": \\\"constructor\\\" \t}, \t{ \t\t\\\"anonymous\\\": false, \t\t\\\"inputs\\\": [ \t\t\t{ \t\t\t\t\\\"indexed\\\": false, \t\t\t\t\\\"internalType\\\": \\\"address\\\", \t\t\t\t\\\"name\\\": \\\"buyer\\\", \t\t\t\t\\\"type\\\": \\\"address\\\" \t\t\t}, \t\t\t{ \t\t\t\t\\\"indexed\\\": false, \t\t\t\t\\\"internalType\\\": \\\"uint256\\\", \t\t\t\t\\\"name\\\": \\\"amountOfBNB\\\", \t\t\t\t\\\"type\\\": \\\"uint256\\\" \t\t\t}, \t\t\t{ \t\t\t\t\\\"indexed\\\": false, \t\t\t\t\\\"internalType\\\": \\\"uint256\\\", \t\t\t\t\\\"name\\\": \\\"amountOfTokens\\\", \t\t\t\t\\\"type\\\": \\\"uint256\\\" \t\t\t} \t\t], \t\t\\\"name\\\": \\\"BuyTokens\\\", \t\t\\\"type\\\": \\\"event\\\" \t}, \t{ \t\t\\\"anonymous\\\": false, \t\t\\\"inputs\\\": [ \t\t\t{ \t\t\t\t\\\"indexed\\\": true, \t\t\t\t\\\"internalType\\\": \\\"address\\\", \t\t\t\t\\\"name\\\": \\\"previousOwner\\\", \t\t\t\t\\\"type\\\": \\\"address\\\" \t\t\t}, \t\t\t{ \t\t\t\t\\\"indexed\\\": true, \t\t\t\t\\\"internalType\\\": \\\"address\\\", \t\t\t\t\\\"name\\\": \\\"newOwner\\\", \t\t\t\t\\\"type\\\": \\\"address\\\" \t\t\t} \t\t], \t\t\\\"name\\\": \\\"OwnershipTransferred\\\", \t\t\\\"type\\\": \\\"event\\\" \t}, \t{ \t\t\\\"inputs\\\": [], \t\t\\\"name\\\": \\\"renounceOwnership\\\", \t\t\\\"outputs\\\": [], \t\t\\\"stateMutability\\\": \\\"nonpayable\\\", \t\t\\\"type\\\": \\\"function\\\" \t}, \t{ \t\t\\\"inputs\\\": [ \t\t\t{ \t\t\t\t\\\"internalType\\\": \\\"address\\\", \t\t\t\t\\\"name\\\": \\\"newOwner\\\", \t\t\t\t\\\"type\\\": \\\"address\\\" \t\t\t} \t\t], \t\t\\\"name\\\": \\\"transferOwnership\\\", \t\t\\\"outputs\\\": [], \t\t\\\"stateMutability\\\": \\\"nonpayable\\\", \t\t\\\"type\\\": \\\"function\\\" \t}, \t{ \t\t\\\"inputs\\\": [], \t\t\\\"name\\\": \\\"withdraw\\\", \t\t\\\"outputs\\\": [], \t\t\\\"stateMutability\\\": \\\"nonpayable\\\", \t\t\\\"type\\\": \\\"function\\\" \t}, \t{ \t\t\\\"inputs\\\": [], \t\t\\\"name\\\": \\\"owner\\\", \t\t\\\"outputs\\\": [ \t\t\t{ \t\t\t\t\\\"internalType\\\": \\\"address\\\", \t\t\t\t\\\"name\\\": \\\"\\\", \t\t\t\t\\\"type\\\": \\\"address\\\" \t\t\t} \t\t], \t\t\\\"stateMutability\\\": \\\"view\\\", \t\t\\\"type\\\": \\\"function\\\" \t}, \t{ \t\t\\\"inputs\\\": [], \t\t\\\"name\\\": \\\"tokensPerBnb\\\", \t\t\\\"outputs\\\": [ \t\t\t{ \t\t\t\t\\\"internalType\\\": \\\"uint256\\\", \t\t\t\t\\\"name\\\": \\\"\\\", \t\t\t\t\\\"type\\\": \\\"uint256\\\" \t\t\t} \t\t], \t\t\\\"stateMutability\\\": \\\"view\\\", \t\t\\\"type\\\": \\\"function\\\" \t} ]";
        // address of contract
        string contract = "0x0A84Fad86F1F16cD9caf6d9cdAefbf8daE17b3C1";
        // array of arguments for contract
        string args = "[]";
        // value in wei
        string value = "1000000000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try
        {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }

}
#endif
using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERC20BalanceOfExample : MonoBehaviour
{
    public Text tokenIncome;

    async void Start()
    {
        string chain = "binance";
        string network = "testnet";
        string contract = "0x6595826877E59F7D103E407bcF19EFD5c6608560";
        string account = PlayerPrefs.GetString("Account");

        BigInteger balanceOf = await ERC20.BalanceOf(chain, network, contract, account);
        print(balanceOf);

        tokenIncome.text = balanceOf.ToString();
    }
}

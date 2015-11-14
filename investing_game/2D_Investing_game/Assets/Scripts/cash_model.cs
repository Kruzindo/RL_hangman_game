using UnityEngine;
using System.Collections;

public class cash_model : MonoBehaviour {

    private int bank_space;
    public int Bank_space
    {
        get
        {
            return bank_space;
        }

        set
        {
            bank_space = value;
        }
    }

    private int saved_cash;
    public int Saved_cash
    {
        get
        {
            return saved_cash;
        }

        set
        {
            saved_cash = value;
        }
    }

    public enum typeOfIncome
    {
        food,
        technology,
        stocks,         //aandelen
        gold,
        others,
        rente           //rente op huidige bedrag op de bank
    }

    
}

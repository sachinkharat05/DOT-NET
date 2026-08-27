using System.Security.Cryptography.X509Certificates;
using FundTransfer.models;

namespace FundTransfer;
public class UIManager
{

    private List<Account> accounts;


public UIManager()
    {
        accounts =new List<Account>();

    }

    public void DisplayAllAccounts(string accountid)
    {
        foreach (Account.checked(accountid))
        {
            Account.Add(accounts);
        }
    }
    //    Public void DisplayAllSaveAccounts(string);





    }
}
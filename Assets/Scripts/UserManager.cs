using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityUITable;
using TMPro;

public class UserManager : MonoBehaviour
{
    [SerializeField] ApiController controller;
    [SerializeField] Button banConfirmButton;
    [SerializeField] Button unbanConfirmButton;
    [SerializeField] Table table;
    [SerializeField] TextMeshProUGUI banTitleText;
    [SerializeField] TextMeshProUGUI banMessageText;

    
    public IList<User> usersList = new List<User>();

    public void fillUsersList()
    {
        controller.UsersGet(usersList);
        table.UpdateContent();
    }

    public void banUser()
    {
        banTitleText.text = "Ban User";
        banMessageText.text = "Put in the index of the User";


        /*
         * Ezt egy button OnClick event-j�vel megh�vjuk
         * Minden egyes megh�v�sn�l el�j�n egy pici form, ami k�ri a sor index�t (term�szetesen Cancel button)
         * Ezt el lehet menteni, amit tov�bb lehet k�ldeni az UserPut-nak, az pedig feldolgozza
         * Ha ez megvan, �jra lek�rj�k a content-et
         */
    }

    public void unbanUser()
    {
        banTitleText.text = "Unban User";
        banMessageText.text = "Put in the index of the User";
    }
}

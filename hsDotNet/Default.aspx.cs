using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using unirest_net.http;
using Newtonsoft.Json.Linq;

namespace hsDotNet
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpResponse<string> response = Unirest.get("https://omgvamp-hearthstone-v1.p.mashape.com/cards/search/Leeroy")
             .header("X-Mashape-Key", "aQyciHvstfmshss50kxkJmlhDtl9p14Yntcjsnwvam1pBiarEU")
             .asJson<string>();
            //JObject json2 = JObject.Parse(response.Body);
            JArray json = JArray.Parse(response.Body);
            //cardLbl.Text = response.Body;

            //cardLbl.Text = response.Body;
            //cardImg.ImageUrl = json[0]["img"].ToString();
            //HearthstoneDs.CardsRow newCardsRow =  northwindDataSet1.Customers.NewCustomersRow();
             HearthstoneDs northwindDataSet = new HearthstoneDs();
            string cardId = json[0]["cardId"].ToString();
            string name = json[0]["name"].ToString();

            HearthstoneDsTableAdapters.CardsTableAdapter cardsTableAdapter = new HearthstoneDsTableAdapters.CardsTableAdapter();
            cardsTableAdapter.InsertCard(cardId, name);


        }
    }
}


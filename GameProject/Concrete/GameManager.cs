using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Sale(Game game, User user)
        {
            Console.WriteLine(game.GameName +" "+ "oyunu" + user.FirstName + user.LastName + "başarıyla satın aldınız tebrikler :)");
        }

        public void SaleCampaign(Game game, User user, Campaign campaign)
        {
            decimal discountprice = game.UnitPrice - campaign.CampaignPrice;
            Console.WriteLine(game.GameName + " " + "oyunu" + campaign.CampaignName + " " + " kampanyası dahilinde" +discountprice
                + " " + "TL kampanyalı fiyatıyla" + user.FirstName + user.LastName + "başarıyla satın aldınız tebrikler :)");
        }
    }
}

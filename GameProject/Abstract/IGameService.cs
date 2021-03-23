using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameService
    {
       void Sale(Game game,User user);
       void SaleCampaign(Game game, User user,Campaign campaign);
    }
}

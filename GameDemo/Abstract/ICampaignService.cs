using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICampaignService
    {
        void CampaignAdd(Campaign campaign,User user);
        void CampaignUpdate(Campaign campaign, User user);
        void CampaignDelete(Campaign campaign, User user);
    }
}

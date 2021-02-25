using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign, User user)
        {
            Console.WriteLine(campaign.CampaignName + ": " + user.FirstName + " İsimli Kullanıcıya Tanımlandı");
        }
        public void CampaignDelete(Campaign campaign, User user)
        {
            Console.WriteLine(campaign.CampaignName + ": " + user.FirstName + " İsimli Kullanıcıdan Kampanya Kaldırıldı.");
        }
        public void CampaignUpdate(Campaign campaign, User user)
        {
            Console.WriteLine("kampanya Güncellendi.");
        }
    }
}

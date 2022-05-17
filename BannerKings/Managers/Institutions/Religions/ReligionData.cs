﻿using BannerKings.Models.BKModels;
using BannerKings.Populations;
using TaleWorlds.CampaignSystem;
using System.Linq;

namespace BannerKings.Managers.Institutions.Religions
{
    public class ReligionData : BannerKingsData
    {
        private Settlement settlement;
        private Clergyman clergyman;
        private Religion religion;

        public ReligionData(Religion religion, Settlement settlement)
        {
            this.religion = religion;
            this.settlement = settlement;
        }

        public Religion Religion => religion;
        public Settlement Settlement => settlement;

        public Clergyman Clergyman
        {
            get
            {
                if (clergyman == null) clergyman = religion.GenerateClergyman(settlement);
                return clergyman;
            }
        }

        internal override void Update(PopulationData data)
        {
            clergyman = religion.GetClergyman(data.Settlement);
            if (clergyman == null)
                clergyman = religion.GenerateClergyman(settlement);

        }
    }
}
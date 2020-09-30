using LOLTeamMaker.Enum;

namespace LOLTeamMaker.Converter
{
    class EnumConverter
    {
        public static string PositionToKoreanString(Position position)
        {
            string result = "";
            switch(position)
            {
                case Position.TOP:
                    result = "탑";
                    break;

                case Position.JGL:
                    result = "정글";
                    break;

                case Position.MID:
                    result = "미드";
                    break;

                case Position.ADC:
                    result = "원딜";
                    break;

                case Position.SUP:
                    result = "서폿";
                    break;

                case Position.ALL:
                    result = "미정";
                    break;
            }

            return result;
        }

        public static string TierToKoreanString(Tier tier)
        {
            string result = "";
            switch (tier)
            {
                case Tier.Bronze:
                    result = "브론즈";
                    break;

                case Tier.Silver:
                    result = "실버";
                    break;

                case Tier.Gold:
                    result = "골드";
                    break;

                case Tier.Platinum:
                    result = "플레티넘";
                    break;

                case Tier.Diamond:
                    result = "다이아몬드";
                    break;

                case Tier.Master:
                    result = "마스터";
                    break;

                case Tier.Gransmaster:
                    result = "그랜드마스터";
                    break;

                case Tier.Challenger:
                    result = "챌린져";
                    break;
            }

            return result;
        }
    }
}

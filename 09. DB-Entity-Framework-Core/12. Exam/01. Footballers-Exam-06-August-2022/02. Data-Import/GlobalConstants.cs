namespace Footballers
{
    public static class GlobalConstants
    {
        //Footballers
        public const int FootballerNameMinLength = 2;
        public const int FootballerNameMaxLength = 40;

        //Teams
        public const int TeamNameMinLength = 3;
        public const int TeamNameMaxLength = 40;
        public const string TeamNameRegex = @"^[A-Za-z\d\s\.\-]+?$";
        public const string TeamTrophiesMinValue = "1";
        public const string TeamTrophiesMaxValue = "2147483647";

        //Coach
        public const int CoachNameMinLength = 2;
        public const int CoachNameMaxLength = 40;

        //Common
        public const int NationalityMinLength = 2;
        public const int NationalityMaxLength = 40;
    }
}

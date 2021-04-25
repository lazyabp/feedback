namespace LazyAbp.FeedbackKit
{
    public static class FeedbackKitDbProperties
    {
        public static string DbTablePrefix { get; set; } = "FeedbackKit";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "FeedbackKit";
    }
}

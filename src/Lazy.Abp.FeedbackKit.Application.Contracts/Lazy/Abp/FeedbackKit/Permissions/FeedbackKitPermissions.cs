using Volo.Abp.Reflection;

namespace Lazy.Abp.FeedbackKit.Permissions
{
    public class FeedbackKitPermissions
    {
        public const string GroupName = "FeedbackKit";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(FeedbackKitPermissions));
        }

        public class Feedback
        {
            public const string Default = GroupName + ".Feedback";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
            public const string Management = Default + ".Management";
            public const string Reply = Default + ".Reply";
        }
    }
}

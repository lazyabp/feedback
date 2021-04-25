using LazyAbp.FeedbackKit.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LazyAbp.FeedbackKit.Permissions
{
    public class FeedbackKitPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FeedbackKitPermissions.GroupName, L("Permission:FeedbackKit"));

            var feedbackPermission = myGroup.AddPermission(FeedbackKitPermissions.Feedback.Default, L("Permission:Feedback"));
            feedbackPermission.AddChild(FeedbackKitPermissions.Feedback.Create, L("Permission:Create"));
            feedbackPermission.AddChild(FeedbackKitPermissions.Feedback.Delete, L("Permission:Delete"));
            feedbackPermission.AddChild(FeedbackKitPermissions.Feedback.Management, L("Permission:Management"));
            feedbackPermission.AddChild(FeedbackKitPermissions.Feedback.Reply, L("Permission:Reply"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FeedbackKitResource>(name);
        }
    }
}

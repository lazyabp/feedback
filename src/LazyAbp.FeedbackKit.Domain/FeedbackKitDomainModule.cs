﻿using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace LazyAbp.FeedbackKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(FeedbackKitDomainSharedModule)
    )]
    public class FeedbackKitDomainModule : AbpModule
    {

    }
}

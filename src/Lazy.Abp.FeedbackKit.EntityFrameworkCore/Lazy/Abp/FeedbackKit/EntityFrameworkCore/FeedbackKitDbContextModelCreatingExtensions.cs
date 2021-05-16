using Lazy.Abp.FeedbackKit;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.FeedbackKit.EntityFrameworkCore
{
    public static class FeedbackKitDbContextModelCreatingExtensions
    {
        public static void ConfigureFeedbackKit(
            this ModelBuilder builder,
            Action<FeedbackKitModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new FeedbackKitModelBuilderConfigurationOptions(
                FeedbackKitDbProperties.DbTablePrefix,
                FeedbackKitDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<Feedback>(b =>
            {
                b.ToTable(options.TablePrefix + "Feedbacks", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}

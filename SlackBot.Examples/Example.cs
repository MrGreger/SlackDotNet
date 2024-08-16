using System.Text.Json.Nodes;
using SlackBotDotNet.BlockKit.Builders.Blocks;
using SlackBotDotNet.BlockKit.Builders.Surfaces;

namespace SlackBot.Examples;

public class Example
{
    void CreateMessage()
    {
        var messageBuilder = new MessageSurfaceBuilder();

        new ContextBlockBuilder().WithText(x =>
                                               x.Markdown()
                                                .Verbatim()
                                                .WithEmoji()
                                                .WithText("123")
                                          ).WithText(x =>
                                                     {
                                                         x.Plain()
                                                          .WithEmoji()
                                                          .WithText("321");
                                                     });

        messageBuilder.AddSection(x =>
                                  {
                                      x.WithButton(x =>
                                                   {
                                                       x.WithText("Test")
                                                        .WithUrl("https://google.com")
                                                        .WithEmoji()
                                                        .WithConfirmationDialog(x =>
                                                                                {
                                                                                    x.WithTitle("Are you sure?")
                                                                                     .WithText("It will delete everything!");
                                                                                });
                                                   });
                                  }).AddSection(x =>
                                                {
                                                    x.WithCheckboxes(x =>
                                                                     {
                                                                         x.AddOption(x =>
                                                                                     {
                                                                                         x.WithText(x => x.Plain()
                                                                                                          .WithText("text"))
                                                                                          .WithValue("0")
                                                                                          .Selected();
                                                                                     }).AddOption(x =>
                                                                                                  {
                                                                                                      x.WithText(x => x
                                                                                                                     .Markdown("mrkdwn")
                                                                                                                     .WithEmoji(false)
                                                                                                                     .Verbatim())
                                                                                                       .WithValue("1")
                                                                                                       .Selected();
                                                                                                  });
                                                                     });
                                                }).AddSection(x =>
                                                              {
                                                                  x.WithDatePicker(x =>
                                                                                   {
                                                                                       x.WithPlaceholder("Your birth date");
                                                                                   });
                                                              })
                      .AddSection(x =>
                                  {
                                      x.WithImage(x =>
                                                  {
                                                      x.WithUrl(
                                                                "https://pbs.twimg.com/profile_images/625633822235693056/lNGUneLX_400x400.jpg");
                                                  });
                                  })
                      .AddSection(x => x.WithMultiSelectMenu(x =>
                                                             {
                                                                 x.AddOption(x => { x.WithText("1"); })
                                                                  .AddOption(x => { x.WithText("2"); });
                                                             })).AddSection(x => x.WithMultiSelectMenu(x =>
                                                                                                       {
                                                                                                           x.AddOptionGroups(x =>
                                                                                                                             {
                                                                                                                                 x.AddOption(x =>
                                                                                                                                                 x.WithText("1_1"))
                                                                                                                                  .AddOption(x =>
                                                                                                                                                 x.WithText("2_2"));
                                                                                                                             });
                                                                                                       }));
    }
}
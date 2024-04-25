using HttpSlackBot.Blocks.Builders;

namespace SlackBot.Examples;

public class Example
{
    void CreateMessage()
    {
        var messageBuilder = new BlockedMessageBuilder();

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
                           x.WithCheckBoxes(x =>
                           {
                               x.AddOption(x =>
                               {
                                   x.WithText("Text")
                                    .WithValue("0")
                                    .Selected();
                               }).AddOption(x =>
                               {
                                   x.WithText("Text")
                                    .WithValue("1")
                                    .Selected();
                               });
                           });
                       }).AddSection(x => { x.WithDatePicker(x => { x.WithPlaceholder("Your birth date"); }); })
                      .AddSection(x =>
                       {
                           x.WithImage(x =>
                           {
                               x.WithUrl(
                                   "https://pbs.twimg.com/profile_images/625633822235693056/lNGUneLX_400x400.jpg");
                           });
                       });
    }
}
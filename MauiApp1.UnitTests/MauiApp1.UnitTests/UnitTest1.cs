using MauiApp1.States.Models;
using MauiApp1.States.Services;
using MauiApp1.PageModels;

namespace MauiApp1.UnitTests
{
    public class AppDataContextTests
    {
        [Fact]
        public void Initial_Number_Is_Zero()
        {
            var context = new AppDataContext();
            Assert.Equal(0, context.Number);
        }

        [Fact]
        public void Number_Updates_Correctly()
        {
            var context = new AppDataContext();
            context.Increment();
            Assert.Equal(1, context.Number);
        }
    }

    public class MainPageModelTests
    {
        [Fact]
        public void Count_Updates_Correctly() {
            var context = new AppDataContext();
            var contextManager = new AppDataContextManager();

            var model = new MainPageModel(context, contextManager);

            model.CountUpCommand.Execute(null);
            Assert.Equal(1, context.Number);
        }
    }
}

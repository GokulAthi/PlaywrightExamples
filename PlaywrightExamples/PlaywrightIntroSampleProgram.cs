using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightExamples
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://www.google.com");

            await page.FillAsync("name=q", "simply technified");

            await page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "sampless.jpg"
            });
        }
    }
}

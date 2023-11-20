

using MeditationTrackerApp.DAL.Interrfaces;
using MeditationTrackerApp.DAL.Services;
using MeditationTrackerApp.DAL.Services.Repository;
using MeditationTrackerApp.Models;
using MeditationTrackerApp.Models;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MeditationTrackerApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IMeditationTrackerService _meditationService;
        public readonly Mock<IMeditationTrackerRepository> meditationservice = new Mock<IMeditationTrackerRepository>();

        private readonly Meditation _meditation;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _meditationService = new MeditationTrackerService(meditationservice.Object);
            _output = output;

            _meditation = new Meditation
            {
                MeditationSessionId = 1,
                Date = DateTime.Now,
                Duration = TimeSpan.FromMinutes(15),
                MeditationType = "Mindfulness",
                Notes = "Focused on breath and body sensations.",
                IsFavorite = true,
                Goal = "Achieve a state of calmness and focus."
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Meditation()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repos => repos.CreateMeditation(_meditation)).ReturnsAsync(_meditation);
                var result = await _meditationService.CreateMeditation(_meditation);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Meditation()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repos => repos.UpdateMeditation(_meditation)).ReturnsAsync(_meditation);
                var result = await _meditationService.UpdateMeditation(_meditation);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetMeditationById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repos => repos.GetMeditationById(id)).ReturnsAsync(_meditation);
                var result = await _meditationService.GetMeditationById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteMeditationById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repos => repos.DeleteMeditationById(id)).ReturnsAsync(response);
                var result = await _meditationService.DeleteMeditationById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}
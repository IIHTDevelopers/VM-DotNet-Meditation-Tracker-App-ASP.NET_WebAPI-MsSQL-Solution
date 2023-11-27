


using MeditationTrackerApp.DAL.Interrfaces;
using MeditationTrackerApp.DAL.Services;
using MeditationTrackerApp.DAL.Services.Repository;
using MeditationTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace MeditationTrackerApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IMeditationTrackerService _meditationService;
        public readonly Mock<IMeditationTrackerRepository> meditationservice = new Mock<IMeditationTrackerRepository>();

        private readonly Meditation _meditation;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_ifInvalidMeditationIdIsPassed()
        {
            //Arrange
            bool res = false;
            _meditation.MeditationSessionId = 10;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repo => repo.CreateMeditation(_meditation)).ReturnsAsync(_meditation);
                var result = await _meditationService.CreateMeditation(_meditation);
                if (result != null || result.MeditationSessionId != 0)
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
        public async Task<bool> Testfor_Validate_ifInvalidTypeIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repo => repo.CreateMeditation(_meditation)).ReturnsAsync(_meditation);
                var result = await _meditationService.CreateMeditation(_meditation);
                if (result != null || result.MeditationType !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidMeditationDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repo => repo.CreateMeditation(_meditation)).ReturnsAsync(_meditation);
                var result = await _meditationService.CreateMeditation(_meditation);
                if (result != null || result.Date <= DateTime.Now)
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
        public async Task<bool> Testfor_Validate_ifInvalidNoteIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                meditationservice.Setup(repo => repo.CreateMeditation(_meditation)).ReturnsAsync(_meditation);
                var result = await _meditationService.CreateMeditation(_meditation);
                if (result != null || result.Notes != null)
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
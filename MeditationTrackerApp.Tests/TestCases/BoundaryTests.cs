

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
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IMeditationTrackerService _meditationService;
        public readonly Mock<IMeditationTrackerRepository> meditationservice = new Mock<IMeditationTrackerRepository>();

        private readonly Meditation _meditation;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_MeditationSessionId_NotEmpty()
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
                var actualLength = _meditation.MeditationSessionId.ToString().Length;
                if (result.MeditationSessionId.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_MeditationDate_NotEmpty()
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
                var actualLength = _meditation.Date.ToString().Length;
                if (result.Date.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_MeditationDuration_NotEmpty()
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
                var actualLength = _meditation.Duration.ToString().Length;
                if (result.Duration.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_MeditationType_NotEmpty()
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
                var actualLength = _meditation.MeditationType.ToString().Length;
                if (result.MeditationType.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Notes_NotEmpty()
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
                var actualLength = _meditation.Notes.ToString().Length;
                if (result.Notes.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_IsFavourite_NotEmpty()
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
                var actualLength = _meditation.IsFavorite.ToString().Length;
                if (result.IsFavorite.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Goal_NotEmpty()
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
                var actualLength = _meditation.Goal.ToString().Length;
                if (result.Goal.ToString().Length == actualLength)
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
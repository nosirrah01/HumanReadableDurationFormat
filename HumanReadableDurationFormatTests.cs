using NUnit.Framework;

namespace HumanReadableDurationFormat.nUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test01()
        {
            // Assign
            int seconds = 0;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("now"));
        }
        [Test]
        public void Test02()
        {
            // Assign
            int seconds = 1;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("1 second"));
        }
        [Test]
        public void Test03()
        {
            // Assign
            int seconds = 62;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("1 minute and 2 seconds"));
        }
        [Test]
        public void Test04()
        {
            // Assign
            int seconds = 120;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("2 minutes"));
        }
        [Test]
        public void Test05()
        {
            // Assign
            int seconds = 3662;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("1 hour, 1 minute and 2 seconds"));
        }
        [Test]
        public void Test06()
        {
            // Assign
            int seconds = 15731080;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("182 days, 1 hour, 44 minutes and 40 seconds"));
        }
        [Test]
        public void Test07()
        {
            // Assign
            int seconds = 132030240;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("4 years, 68 days, 3 hours and 4 minutes"));
        }
        [Test]
        public void Test08()
        {
            // Assign
            int seconds = 205851834;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("6 years, 192 days, 13 hours, 3 minutes and 54 seconds"));
        }
        [Test]
        public void Test09()
        {
            // Assign
            int seconds = 253374061;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("8 years, 12 days, 13 hours, 41 minutes and 1 second"));
        }
        [Test]
        public void Test10()
        {
            // Assign
            int seconds = 242062374;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("7 years, 246 days, 15 hours, 32 minutes and 54 seconds"));
        }
        [Test]
        public void Test11()
        {
            // Assign
            int seconds = 101956166;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("3 years, 85 days, 1 hour, 9 minutes and 26 seconds"));
        }
        [Test]
        public void Test12()
        {
            // Assign
            int seconds = 33243586;
            // Act
            string duration = HumanTimeFormat.formatDuration(seconds);
            //Assert
            Assert.That(duration, Is.EqualTo("1 year, 19 days, 18 hours, 19 minutes and 46 seconds"));
        }
    }
}
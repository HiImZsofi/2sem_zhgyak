using zhgyak;
namespace tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(50, 200, false)]
        [TestCase(300, 400, false)]
        [TestCase(502, 1000, true)]
        public void Envelope1(int weight, int expected, bool automata)
        {
            Envelope e = new Envelope(weight, "asd", "asd");

            Assert.That(e.CalculatePrice(automata), Is.EqualTo(expected));
        }

        [Test]
        public void Envelope2()
        {
            Envelope e = new Envelope(2001, "asd", "asd");

            Assert.Throws<OverweightException>(() => e.CalculatePrice(true));
        }

        [Test]
        public void Fragile1()
        {
            FragileParcel f = new FragileParcel(500, "asd", Orientation.Horizontal);

            Assert.That(f.CalculatePrice(false), Is.EqualTo(2000));
        }

        [Test]
        public void Fragile2()
        {
            FragileParcel f = new FragileParcel(500, "asd", Orientation.Arbitrary);

            Assert.Throws<IncorrectOrientationException>(() => f.CalculatePrice(false));
        }
    }
}
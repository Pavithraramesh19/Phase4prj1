using Moq;
using ClassLibrary1;
namespace Phase_4_prj_1
{
    [TestFixture]
    public class Tests
    {
        SchoolManagement schmgmt;
        [SetUp]
        public void Setup()
        {
            schmgmt = new SchoolManagement();
        }

        [Test]
        public void AllStuNotNull()
        {
            foreach (School sc in schmgmt.AllStulist())
            {
                Assert.IsNotNull(sc.StuId);
                Assert.IsNotNull(sc.SubName);
                Assert.IsNotNull(sc.TeacherName);
                Assert.IsNotNull(sc.SubName);
            }
        }
        [Test]
        public void SearchStuTest()
        {
            int id = 2;
            string Name = "Gowtham";
            foreach(School sc in schmgmt.SearchStu(2))
            {
                Assert.That(sc.StuId, Is.EqualTo(id));
                Assert.That(sc.StuName, Is.EqualTo(Name));
            }
        }
        [Test]
        public void StumarkTest()
        {
            Mock<SchoolManagement> mock = new Mock<SchoolManagement>();
            mock.Setup(x => x.StudentMarks()).Returns(true);
            Assert.That(mock.Object.StudentMarks(), Is.EqualTo(true));
        }
    }
}
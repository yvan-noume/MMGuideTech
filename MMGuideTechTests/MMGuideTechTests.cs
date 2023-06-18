using Microsoft.VisualStudio.TestPlatform.TestHost;
using MMGuideTech;

namespace MMGuideTechTests
{
    [TestClass]
    public class MMGuideTechTests
    {
        private LinkedList<String> my_list;
        private LinkedList<int> my_list2;
        BinarySearchTree binarySearchTree = new BinarySearchTree();

        [TestInitialize]
        public void Initialize()
        {
            my_list = new LinkedList<String>(new string[] { "Zoya", "Shilpa", "Rohit", "Rohan", "Juhi" });
            my_list2 = new LinkedList<int>(new int[] { 1,2,3,4,5,6,7,8 });
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(17);
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(23);
            binarySearchTree.Insert(14);
            binarySearchTree.Insert(19);
            binarySearchTree.Insert(12);
            binarySearchTree.Insert(76);
            binarySearchTree.Insert(54);
            binarySearchTree.Insert(72);
            binarySearchTree.Insert(67);
        }

        [TestMethod]
        public void ReverseLoopTests()
        {
            CollectionAssert.AreEqual(new LinkedList<String>(new string[] { "Juhi", "Rohan", "Rohit", "Shilpa", "Zoya" }), MMGuideTech.Program.ReverseLoop<string>(ref my_list) );
            CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 8,7,6,5,4,3,2,1 }), MMGuideTech.Program.ReverseLoop<int>(ref my_list2) );
        }

        [TestMethod]
        public void ReverseRecursionTests()
        {
            CollectionAssert.AreEqual(new LinkedList<String>(new string[] { "Juhi", "Rohan", "Rohit", "Shilpa", "Zoya" }), MMGuideTech.Program.ReverseRecursion<string>(ref my_list));
            CollectionAssert.AreEqual(new LinkedList<int>(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }), MMGuideTech.Program.ReverseRecursion<int>(ref my_list2));
        }

        [TestMethod]
        public void AnagramTests()
        {
            Assert.AreEqual(true, MMGuideTech.Program.Anagram("dormitory", "dirty room"));
            Assert.AreEqual(true, MMGuideTech.Program.Anagram("debit card", "bad credit"));
            Assert.AreEqual(false, MMGuideTech.Program.Anagram("hello world", "hello"));
        }

        [TestMethod]
        public void ParentNodeTests()
        {
            CollectionAssert.AreEqual(new List<int> { 14,23,72}, MMGuideTech.Program.ParentNode(binarySearchTree._root));
        }
    }
}
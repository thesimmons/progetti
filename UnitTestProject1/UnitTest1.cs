
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using TestIteratori;
namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        
        public void Sequence_Null_Throws_ArgumentException()
        {
            var i = Program.MacroExpansion(null, 2, new[] { 7, 8, 9 });
            Assert.That( ()=> i.First(),Throws.TypeOf<ArgumentNullException>());
            // Assert.Throws<ArgumentNullException>(() => Program.MacroExpansion(null, 2, new int[] { 7, 8, 9 }));
        }

        [Test]
        public void NewSequence_Null_Throws_ArgumentException()
        {
            var i = Program.MacroExpansion(new[] { 1, 2, 1, 2, 3 }, 2, null);
            Assert.That(() => i.First(), Throws.TypeOf<ArgumentNullException>());
            // Assert.Throws<ArgumentNullException>(() => Program.MacroExpansion(null, 2, new int[] { 7, 8, 9 }));
        }

        [Test]
        public void Value_Not_In_Sequence()
        {
            var i = Program.MacroExpansion(new[] {1, 2, 1, 2, 3}, 6, new[] {7, 8, 9});
            Assert.That(()=>i.First(), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void One_Time()
        {
            var seq = new[] {1, 2, 1, 2, 3};
            var val = 3;
            var new_seq = new[] {7, 8, 9};
            var correct_res = new[] {1, 2, 1, 2, 7, 8, 9};
            var res = new List<int>();
            foreach (var i in Program.MacroExpansion(seq, val, new_seq))
            {
                res.Add(i);
            }

            Assert.That(res, Is.EqualTo(correct_res));

        }







        [Ignore("prova")]
        [Test]
        public void Tre()
        {
             Assert.That(() => Program.Prova((int[])null/*new int[]{1}*/), Throws.TypeOf<ArgumentNullException>());
            //Assert.That(()=>Program.Prova(),Is.EqualTo(3));
        }
    }
}

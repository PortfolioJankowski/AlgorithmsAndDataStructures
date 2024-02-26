using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Tests
{
    [TestFixture]
    public class SortingTests
    {
        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] {2, 1 };
            samples[2] = new[] { 2,1,3 };
            samples[3] = new[] { 1,1,1 };
            samples[4] = new[] { 2,-1,3,3 };
            samples[5] = new[] { 4,-5,3,3 };
            samples[6] = new[] { 0,-5,3,3 };
            samples[7] = new[] { 0,-5,3,0 };
            samples[8] = new[] { 3,2,5,5,1,0,7,8 };

            return samples;

        }
        //Action - Delegat reprezentujący metodę przyjmującą argument (tablicę liczb całkowitych)
        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        //Metoda, która będzie rozpisywać każdą tablicę wg wzoru
        private void PrintOut(int[] sample)
        {
            TestContext.WriteLine("____TRACE_____\n");
            foreach (var el in sample)
            {
                TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n-----------------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInut()
        {
            RunTestsForSortAlgorithm(Sorting.BubbleSort);
        }

        [Test]
        public void SelectionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(Sorting.SelectionSort);
        }
    }
}
